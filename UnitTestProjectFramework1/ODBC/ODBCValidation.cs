using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;
using UnitTestProjectFramework1.ExtentReport;
using UnitTestProjectFramework1.Objectrepo;

namespace UnitTestProjectFramework1.ODBC
{
    [TestClass]
    public class ODBCValidation : ExtentReportgeneration
    {
        [TestMethod]
        [TestCategory("ODBC")]

        public void Validation()
        {
            extenttest = extentreport.CreateTest(TestContext.TestName);
            string connectionstring = "Driver={MySQL ODBC 8.1 Unicode Driver};" + "Server=rmgtestingserver:3333;" + "Database=projects;" + "User=root@%;" + "Password=root;";
            OdbcConnection connection=new OdbcConnection(connectionstring);
            string query = "select * from project;";
            connection.Open();
            OdbcCommand command = new OdbcCommand(query, connection);
            var tables= command.ExecuteReader();
            Console.WriteLine(tables.Read());

            while (tables.Read())
            {

                extenttest.Log(Status.Info, tables[0].ToString()+" " + tables[1].ToString()+" "+ tables[2].ToString() + " "+tables[3].ToString() + " "+tables[4].ToString());
                Console.WriteLine(tables[0]+" " + tables[1]+" " + tables[2]+" " + tables[3].ToString() + " " + tables[4].ToString());
            }
            connection.Close();
        }

    }
}
