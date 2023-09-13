using System.Collections.ObjectModel;
using CC30;

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
Console.WriteLine($"Said:{hashMap.Get("Said")}");
Console.WriteLine($"Ala'a:{hashMap.Get("Ala'a")}");
Console.WriteLine($"Fares:{hashMap.Get("Fares")}");

Console.WriteLine($"Said:{hashMap.Has("Said")}");
Console.WriteLine($"Ala'a:{hashMap.Has("Ala'a")}");
Console.WriteLine($"Fares:{hashMap.Has("Fares")}");
Collection<string> collection = new Collection<string>();
collection = hashMap.Keys();
Console.WriteLine(collection[0]);

