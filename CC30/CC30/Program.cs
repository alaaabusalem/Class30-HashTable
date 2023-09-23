using System.Collections;
using System.Collections.ObjectModel;
using CC30;


namespace CC30
{
	public class Program
	{
		public static void Main(string[] args)
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

			hashMap.Print();
			Console.WriteLine($"////////////////////////////////////////////////////////////////////");

			Console.WriteLine($"Said:{hashMap.Get("Said")}");
			Console.WriteLine($"Ala'a:{hashMap.Get("Ala'a")}");
			Console.WriteLine($"Fares:{hashMap.Get("Fares")}");

			Console.WriteLine($"Said:{hashMap.Has("Said")}");
			Console.WriteLine($"Ala'a:{hashMap.Has("Ala'a")}");
			Console.WriteLine($"Fares:{hashMap.Has("Fares")}");
			Collection<string> collection = new Collection<string>();
			collection = hashMap.Keys();
			Console.WriteLine(collection[0]);
			Console.WriteLine(RepeatedWord("Once upon a time, there was a brave princess who..."));

			Console.WriteLine(RepeatedWord("It was the best of times, it was the worst of times, it was the age of wisdom, it was the age of foolishness, it was the epoch of belief, it was the epoch of incredulity, it was the season of Light, it was the season of Darkness, it was the spring of hope, it was the winter of despair, we had everything before us, we had nothing before us, we were all going direct to Heaven, we were all going direct the other way – in short, the period was so far like the present period, that some of its noisiest authorities insisted on its being received, for good or for evil, in the superlative degree of comparison only..."));

			Console.WriteLine(RepeatedWord("It was a queer, sultry summer, the summer they electrocuted the Rosenbergs, and I didn’t know what I was doing in New York..."));

			// CC33
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
			Hashtable leftJoin = LeftJoni(synonyms, antonyms);
			foreach (DictionaryEntry key in leftJoin)
			{
				string[] array = (string[])key.Value;
				Console.Write(array[0]+"=>");
                Console.Write(array[1]+ "=>");
                Console.Write(array[2]);
				Console.WriteLine();
            }
        }
        public static string RepeatedWord(string word)
		{
			var wordList = word.Split(' ');
			wordList = TrimStringEnd(wordList);
			HashMap hashMa = new HashMap(wordList.Length);
			foreach (string item in wordList)
			{

				if (hashMa.Has(item.ToLower())) return item;

				hashMa.Set(item.ToLower(), item.ToLower());
			}


			return "there is No repeating words";
		}

		public static string[] TrimStringEnd(string[] list)
		{
			char[] charsToRemove = { ',', '.' };
			//string[] answer = list;
			for (int i = 0; i < list.Length; i++)
			{
				list[i] = list[i].TrimEnd(charsToRemove);
			}
			return list;
		}

		public static Hashtable LeftJoni(HashMap synonyms, HashMap antonyms)
		{
			Collection<string> synonymscollection = synonyms.Keys();
            Collection<string> antonymscollection = antonyms.Keys();
            Hashtable leftJoin = new Hashtable();
			foreach(string key in synonymscollection)
			{
				string[] array=new string[3];
				array[0] = key;
				array[1]= synonyms.Get(key);
				array[2]= antonyms.Get(key); 
				leftJoin.Add(key, array);
            }
			return leftJoin;
		}

                 

            
        
    }
}



	


