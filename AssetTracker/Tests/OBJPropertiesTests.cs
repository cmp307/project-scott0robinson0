using System.Xml.Linq;

namespace Tests
{
    [TestClass]
    public class OBJPropertiesTests
    {
        public HardwareAsset hardwareAsset = new(
                "testname",
                "testipaddress",
                "testpurchasedate",
                "testnote",
                "testmodel",
                "testtype",
                "testmanufacturer");

        public HardwareAsset hardwareAssetNoOptional = new();

        public void InitialiseHardwareAssetNoOptional()
        {
            hardwareAssetNoOptional.Name = "Name";
            hardwareAssetNoOptional.IpAddress = "127.0.0.1";
            hardwareAssetNoOptional.ModelName = "testmodel";
            hardwareAssetNoOptional.Type = "testtype";
            hardwareAssetNoOptional.Manufacturer = "Microsoft";
        }

        [TestMethod]
        public void GetNamesAllProperties()
        {
            List<string> names = Classes.OBJProperties.GetNames(hardwareAsset);

            string[] expectedArray = { "name", "ipaddress", "purchasedate", "note", "modelname", "type", "manufacturer" };
            List<string> expected = new(expectedArray);

            CollectionAssert.AreEquivalent(expected, names);
        }

        [TestMethod]
        public void GetValuesAllProperties()
        {
            List<string> values = Classes.OBJProperties.GetValues(hardwareAsset);

            string[] expectedArray = { "testname", "testipaddress", "testpurchasedate", "testnote", "testmodel", "testtype", "testmanufacturer" };
            List<string> expected = new(expectedArray);

            CollectionAssert.AreEquivalent(expected, values);
        }

        [TestMethod]
        public void GetAllProperties()
        {
            Dictionary<string, string> properties = Classes.OBJProperties.GetProperties(hardwareAsset);

            Dictionary<string, string> expected = new();
            expected.Add("name", "testname");
            expected.Add("ipaddress", "testipaddress");
            expected.Add("purchasedate", "testpurchasedate");
            expected.Add("note", "testnote");
            expected.Add("modelname", "testmodel");
            expected.Add("type", "testtype");
            expected.Add("manufacturer", "testmanufacturer");

            CollectionAssert.AreEquivalent(expected, properties);
        }

        [TestMethod]
        public void GetValuesWithoutOptional()
        {
            InitialiseHardwareAssetNoOptional();

            List<string> values = Classes.OBJProperties.GetValues(hardwareAssetNoOptional);
            string[] expectedArray = { "Name", "127.0.0.1", "testmodel", "testtype", "Microsoft" };
            List<string> expected = new(expectedArray);

            CollectionAssert.AreEquivalent(expected, values);
        }

        [TestMethod]
        public void GetNamesWithoutOptional()
        {
            InitialiseHardwareAssetNoOptional();

            List<string> names = Classes.OBJProperties.GetNames(hardwareAssetNoOptional);
            string[] expectedArray = { "name", "ipaddress", "modelname", "type", "manufacturer" };
            List<string> expected = new(expectedArray);

            CollectionAssert.AreEquivalent(expected, names);
        }
    }
}
