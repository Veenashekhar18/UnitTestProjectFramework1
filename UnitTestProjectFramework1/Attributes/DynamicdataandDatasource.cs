using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attributes
{
    [TestClass]
    [TestCategory("data")]
    public class DynamicdataandDatasource
    {
        [TestMethod]
        [DynamicData(nameof(places),DynamicDataSourceType.Method)]
        public void Dynamicdata(string places,string value)
        {
            Console.WriteLine($"Attributes are {places} and positions are {values}");
        }

        public static IEnumerable<object[]> Places()
        {
            Spreadsheet spreadsheet=new Spreadsheet();


    }
}
