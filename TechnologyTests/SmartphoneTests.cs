using Technology;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnologyTests
{
    [TestClass]
    internal class SmartphoneTests
    {
        [TestMethod]
        public void Test6SmartphoneInheritsComputerMethods()
        {
            Smartphone iphone8 = new Smartphone("Apple", 2, "iOS", false);
            string expectedOutput = $"Manufacturer: {iphone8.Manufacturer}\n" +
                $"Memory Amount: {iphone8.MemoryAmountGB}gb\n" +
                $"OS: {iphone8.OS}\n" +
                $"Power Status: {iphone8.IsOn}\n";
            Assert.AreEqual(expectedOutput, iphone8.GetInfo());
            iphone8.PowerOnOff();
            Assert.IsTrue(iphone8.IsOn);
        }

        [TestMethod]
        public void Test7IsPhoneGoodMethodReturnsProperString()
        {
            string expectedOutput = "Bleh! Whyyyyyyy... please Apple?";
            Smartphone iphone8 = new Smartphone("Apple", 2, "iOS", false);
            Assert.AreEqual(iphone8.IsPhoneGood(), expectedOutput);
        }
    }
}
