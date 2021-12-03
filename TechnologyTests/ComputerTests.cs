using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class ComputerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, true);
        }

        //WARNING: I MADE EVERYTHING IN THE CLASSES PUBLIC (INCLUDING THE CLASSES THEMSELVES)
        //SO THEY CAN BE REFERENCED IN THE TEST

        [TestMethod]
        public void Test2GetInfoReturnsInfoString()
        {
            Computer computer = new Computer("HP", 16, "Windows");
            string expectedOutput = $"Manufacturer: {computer.Manufacturer}\n" +
                $"Memory Amount: {computer.MemoryAmountGB}gb\n" +
                $"OS: {computer.OS}\n" +
                $"Power Status: {computer.IsOn}\n";
            Assert.AreEqual(computer.GetInfo(), expectedOutput);
        }

        [TestMethod]
        public void Test3PowerOnOffTogglesIsOn()
        {
            Computer computer = new Computer("HP", 16, "Windows");
            computer.PowerOnOff();
            Assert.IsTrue(computer.IsOn);
        }
    }
}
