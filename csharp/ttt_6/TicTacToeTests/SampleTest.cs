
using NUnit.Framework;
//using TicTacToe;

namespace TicTacToe {
    
    [TestFixture]
    public class SampleTest {
        
        [Test]
        public void ExampleTest() {
            Assert.IsTrue(true);
//            Assert.Fail("force failure to see CI fail");
        }
        [Test]
        public void Verify_Thirteen_Char() {
            Assert.AreEqual(13, NewClass.ISBN.Length);
//            Assert.Fail("force failure to see CI fail");
        }
    }

    public class NewClass{
        public static string ISBN {
            get{return "1234567890123";}
            // return "1234567890123";
        }
    }

}
