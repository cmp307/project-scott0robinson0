using Classes.Database;

namespace Tests
{
    [TestClass]
    public class GeneralDBTests : GeneralDB
    {
        [TestMethod]
        public void ListToColumnsStringTest()
        {
            string[] columnsArray = { "name", "ipaddress", "purchasedate", "note", "model", "type", "manufacturer" };
            List<string> columns = new(columnsArray);
            string columnsString = GeneralDB.ListToColumnsString(columns);

            Assert.AreEqual("name, ipaddress, purchasedate, note, model, type, manufacturer", columnsString);
        }

        [TestMethod]
        public void ListToValuesStringTest()
        {
            string[] valuesArray = { "testname", "testipaddress", "testpurchasedate", "testnote", "testmodel", "testtype", "testmanufacturer" };
            List<string> values = new(valuesArray);
            string valuesString = GeneralDB.ListToValuesString(values);

            Assert.AreEqual("'testname', 'testipaddress', 'testpurchasedate', 'testnote', 'testmodel', 'testtype', 'testmanufacturer'", valuesString);
        }

        [TestMethod]
        public void DictionaryToSetValuesStringTest()
        {
            Dictionary<string, string> values = new();
            values.Add("key", "value");
            values.Add("testkey", "testvalue");
            values.Add("thirdkey", "thirdvalue");
            values.Add("anotherkey", "anothervalue");

            string valuesString = GeneralDB.DictionaryToSetValuesString(values);

            Assert.AreEqual("key = 'value', testkey = 'testvalue', thirdkey = 'thirdvalue', anotherkey = 'anothervalue'", valuesString);
        }
    }
}
