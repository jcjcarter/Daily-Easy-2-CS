using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Daily_Easy_2_CS
{
    [TestClass]
   public class TestCal
    {
        Cal cal;

        /// <summary>
        /// Tests the getForce method.
        /// </summary>
        [TestMethod]
        public void Test_getForce() {
            cal = new Cal();
            cal.setForce(90);
            Assert.AreEqual(90, cal.getForce());
        }

        /// <summary>
        /// Tests the set and get acceleration method.
        /// </summary>
        [TestMethod]
        public void test_getAcceleration() {
            cal = new Cal();
            cal.setAcceleration(88);
            Assert.AreEqual(88, cal.getAcceleration());
        }
    }
}
