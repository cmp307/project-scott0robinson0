namespace Tests
{
    [TestClass]
    public class HardwareAssetTests
    {

        [TestMethod]
        public void Constructor()
        {
            HardwareAsset hardwareAsset = new(
                "testname",
                "testip",
                "testpurchasedate",
                "testnote",
                "testmodel",
                "testtype",
                "testmanufacturer");

            Assert.AreEqual("testname", hardwareAsset.Name);
            Assert.AreEqual("testip", hardwareAsset.IpAddress);
            Assert.AreEqual("testmodel", hardwareAsset.Model);
            Assert.AreEqual("testtype", hardwareAsset.Type);
            Assert.AreEqual("testmanufacturer", hardwareAsset.Manufacturer);
            Assert.AreEqual("testpurchasedate", hardwareAsset.PurchaseDate);
            Assert.AreEqual("testnote", hardwareAsset.Note);
        }

        [TestMethod]
        public void RetrieveData()
        {
            HardwareAsset hardwareAsset = new();

            hardwareAsset.RetrieveData();

            Assert.IsNotNull(hardwareAsset.Name);
            Assert.IsNotNull(hardwareAsset.IpAddress);
            Assert.IsNotNull(hardwareAsset.Model);
            Assert.IsNotNull(hardwareAsset.Type);
            Assert.IsNotNull(hardwareAsset.Manufacturer);
        }
    }
}