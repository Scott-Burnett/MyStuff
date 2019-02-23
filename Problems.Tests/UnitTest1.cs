using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1(){
			Program p = new Program();
            string result = p.Prefix("hello");
			Assert.AreEqual(result, "5,1:hello" );
        }
		
		[Test]
		public void Test2(){
			Program p = new Program();
			string result = p.Prefix("");
			Assert.AreEqual(result, "0,0:");
		}
		
		[Test]
		public void Test3(){
			Program p = new Program();
			string result = p.Prefix("what  ...  did  you  say?? ");
			Assert.AreEqual(result, "27,5:what  ...  did  you  say?? ");
		}
    }
}