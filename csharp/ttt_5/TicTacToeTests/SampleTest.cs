
using NUnit.Framework;

namespace TravisTests {
    
    [TestFixture]
    public class SampleTest {
        
        [Test]
        public void ExampleTest() {
            Assert.Fail("force failure to see CI fail");
        }
    }
}
