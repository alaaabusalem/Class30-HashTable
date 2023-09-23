using CC30;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections;

namespace TestCC23
{
	public class UnitTest1
	{
		[Fact]
		public void test()
		{
			HashMap hashMap = new HashMap(10);

			hashMap.Set("Ahmad", "Civil Engineer");
			hashMap.Set("Osama", "Mechanical Engineer");
			hashMap.Set("Zaid", "Doctor");
			hashMap.Set("Mohammad", "CS");
			hashMap.Set("Bashar", "CIS");
			hashMap.Set("Anas", "SE");
			hashMap.Set("Ala'a", "Math");
			hashMap.Set("Abdullah", "Chemistry");
			hashMap.Set("Yaman", "Physics");
			hashMap.Set("Said", "CS");
			Assert.Equal("Civil Engineer", hashMap.Get("Ahmad"));
			Assert.Equal("Null", hashMap.Get("Kady"));
			Assert.Equal(true, hashMap.Has("Osama"));
			Assert.Equal(false, hashMap.Has("Kady"));
			Assert.Equal(10, hashMap.Keys().Count);


		}
		// CC31
		[Fact]

		public void testrepetedWord()
		{
			string words1 = "Once upon a time, there was a brave princess who...";
			string words2 = "It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only...";
			string words3 = "It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York...";
			
			Assert.Equal("a",CC30.Program.RepeatedWord(words1) );
			Assert.Equal("it", CC30.Program.RepeatedWord(words2));

			Assert.Equal("summer", CC30.Program.RepeatedWord(words3));


		}

		//CC33
        [Fact]

        public void testLeftJoin()
        {

            HashMap synonyms = new HashMap(5);
            synonyms.Set("diligent", "employed");
            synonyms.Set("fond", "enamored");
            synonyms.Set("guide", "usher");
            synonyms.Set("outfit", "garb");
            synonyms.Set("wrath", "anger");

            HashMap antonyms = new HashMap(5);
            antonyms.Set("diligent", "idle");
            antonyms.Set("fond", "averse");
            antonyms.Set("guide", "follow");
            antonyms.Set("flow", "jam");
            antonyms.Set("wrath", "delight");
            Hashtable leftJoin = CC30.Program.LeftJoni(synonyms, antonyms);
			string[] array = (string[])leftJoin["diligent"];
            Assert.Equal("diligent", array[0]);
            Assert.Equal("employed", array[1]);
            Assert.Equal("idle", array[2]);




        }
    }
}