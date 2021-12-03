using Technology;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TechnologyTests
{
    [TestClass]
    internal class LaptopTests
    {
        [TestMethod]
        public void Test4LaptopInheritsComputerMethods()
        {
            Laptop macbookAir = new Laptop("Apple", 8, "macOS", false);
            string expectedOutput = $"Manufacturer: {macbookAir.Manufacturer}\n" +
                $"Memory Amount: {macbookAir.MemoryAmountGB}gb\n" +
                $"OS: {macbookAir.OS}\n" +
                $"Power Status: {macbookAir.IsOn}\n";
            Assert.AreEqual(expectedOutput, macbookAir.GetInfo());
            macbookAir.PowerOnOff();
            Assert.IsTrue(macbookAir.IsOn);
        }

        [TestMethod]
        public void Test5UpdateMemoryAmountWorks()
        {
            Laptop macbookAir = new Laptop("Apple", 8, "macOS", false);
            macbookAir.UpdateMemoryAmount(8);
            Assert.AreEqual(16, macbookAir.MemoryAmountGB);
        }
    }
}
