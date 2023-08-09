using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attri13
{
    [TestClass]
    public class DatafetchfromxlCsV : AssemblyTest
    {
        public const string excelfilepath = "D:\\VisualStudioRepos\\UnitTestProjectFramework1\\" +
            "UnitTestProjectFramework1\\Repository\\Data.xlsx";

        [TestMethod]
        [DataSource("System.Data.Oledb", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excelfilepath +
            ";Extended Properties=Excel 12.0","Data$", DataAccessMethod.Sequential)]


        public void Datafetch()

        {
            Console.WriteLine(testContext.DataRow["city"].ToString());
            var city = testContext.DataRow["city"].ToString();
            var code = testContext.DataRow["code"].ToString();
            Console.WriteLine($"city is {city} and citycode {code}");
        }
    }
}
