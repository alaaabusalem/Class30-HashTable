using CC30;

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
	}
}