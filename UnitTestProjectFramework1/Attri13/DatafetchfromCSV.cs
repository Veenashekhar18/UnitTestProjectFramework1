using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attri13
{
    [TestClass]
    public class DatafetchfromCSV : AssemblyTest
    {
        public const string filepath = "D:\\VisualStudioRepos\\UnitTestProjectFramework1" +
            "\\UnitTestProjectFramework1\\Repository\\GetdataCSV.csv";
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", filepath, "GetDatacsv#csv",
            DataAccessMethod.Sequential)]
        public void FetchData()
        {
            Console.WriteLine(testContext.DataRow["email"]);
            Console.WriteLine(testContext.DataRow[1]);
            Console.WriteLine(testContext.DataRow[2]);
        }

        
    }
}
