using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC30
{
	public class HashMap
	{
		// Buckets == a pre determined (size) array 
		// The map is an array of linkedlsit of type KeyValuePair


		public LinkedList<KeyValuePair<string, string>>[] Map { get; set; }

		public HashMap(int size)
		{
			Map = new LinkedList<KeyValuePair<string, string>>[size];
		}

		private int Hash(string key)
		{
			int hashValue = 0;

			char[] letters = key.ToCharArray();

			for (int i = 0; i < letters.Length; i++)
			{
				//hashValue += letters[i]; /// Integer representation
				hashValue += letters[i] * (i + 1); // Multiply each character by its position

			}

			//0 - 9
			hashValue = (hashValue * 599) % Map.Length;

			return hashValue;
		}

		public void Set(string key, string value)
		{
			int hashKey = Hash(key);

			if (Map[hashKey] == null)
			{
				Map[hashKey] = new LinkedList<KeyValuePair<string, string>>();
			}

			KeyValuePair<string, string> entry = new KeyValuePair<string, string>(key, value);

			Map[hashKey].Insert(entry);

		}

		public void Print()
		{
			for (int i = 0; i < Map.Length; i++)
			{

				if (Map[i] == null)
				{
					Console.WriteLine($"Bucket {i}: Empty");
				}

				else
				{
					Console.WriteLine($"Bucket {i}");

					Node<KeyValuePair<string, string>> current = Map[i].Head;

					while (current != null)
					{
						Console.Write($"[{current.Value.Key}] : [{current.Value.Value}] =>");

						current = current.Next;
					}
				}

			}
		}

		public string Get(string key)
		{
			// What bucket this key in
			// Hash(key) wiil give us the index on the map
			int hashValue = Hash(key);

			if (Map[hashValue] == null)
			{
				return $"Bucket {hashValue}: Empty";

			}
			// travrese the linkedlist (if it is there)
			// Examine the node one by pne and if the key we are looking for 
			// return the value
			if (Map[hashValue].Head != null)
			{
				Node<KeyValuePair<string, string>> node = Map[hashValue].Head;
				while (node != null)
				{
					if (node.Value.Key == key)
					{
						return node.Value.Value;
					}
					node = node.Next;

				}
			}
			return "Null";

		}
		public bool Has(string key)
		{
			// What bucket this key in
			// Hash(key) wiil give us the index on the map
			int hashValue = Hash(key);

			if (Map[hashValue] == null)
			{
				return false;

			}
			// travrese the linkedlist (if it is there)
			// Examine the node one by pne and if the key we are looking for 
			// return true/ false if we found it
			if (Map[hashValue].Head != null)
			{
				Node<KeyValuePair<string, string>> node = Map[hashValue].Head;
				while (node != null)
				{
					if (node.Value.Key == key)
					{
						return true;
					}
					node = node.Next;

				}
			}
			return false;

		}
		public Collection<string> Keys()
		{
			Collection<string> collection = new Collection<string>();
			foreach (var List in Map)
			{
				if (List != null)
				{
					Node<KeyValuePair<string, string>> node = List.Head;
					while (node != null)
					{
						collection.Add(node.Value.Key);
						node = node.Next;
					}
				}
			}
			return collection;


		}
		 public int GetSize()
		{

			return Map.Length;
		}

	}
}
