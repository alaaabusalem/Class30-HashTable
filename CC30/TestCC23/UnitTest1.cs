using CC30;
using Microsoft.VisualStudio.TestPlatform.TestHost;

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
			Assert.Equal("the key Kady is Not exist", hashMap.Get("Kady"));
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
	}
}