using Bytescout.Spreadsheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attributes
{
    [TestClass]
    [TestCategory("Data")]
    public class DynamicdataandDatasource
    {
        [TestMethod]
        [TestCategory ("Data")]
        [DynamicData(nameof(place),DynamicDataSourceType.Method)]
        public void Dynamicdatafetch(string Place, string value)
        {
            Console.WriteLine($"place names are {Place} and values are {value}");
        }

        public static IEnumerable<object[]> place()
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            spreadsheet.LoadFromFile("D:\\VisualStudioRepos\\UnitTestProjectFramework1\\UnitTestProjectFramework1\\Repository\\C# data.xlsx");
            var sheet = spreadsheet.Workbook.Worksheets["Data"];
            var maxrow = sheet.UsedRangeRowMax;
            var maxcol = sheet.UsedRangeColumnMax;
            for (int i = 0; i < maxrow; i++)
            {
                string Place = sheet.Cell(i, 0).ToString();
                string value = sheet.Cell(i, 1).ToString();
                yield return new object[] { Place, value };
            }



        }
    }
}
