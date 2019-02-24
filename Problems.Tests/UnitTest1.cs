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
            //Arrange
			Program p = new Program();

            //Act
            string result = p.Prefix("hello");

            //Assert
			Assert.AreEqual(result, "5,1:hello" );
        }
		
		[Test]
		public void Test2(){
            //Arrange
			Program p = new Program();

            //Act
            string result = p.Prefix("");

            //Assert
            Assert.AreEqual(result, "0,0:");
		}
		
		[Test]
		public void Test3(){
            //Arrange
			Program p = new Program();

            //Act
            string result = p.Prefix("what  ...  did  you  say?? ");

            //Assert
            Assert.AreEqual(result, "27,5:what  ...  did  you  say?? ");
		}
    }
}