using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectFramework1
{
    [TestClass]
    public class AssemblyTest
    {

        [AssemblyInitialize]
        public static void AssemblyIni(TestContext context)
        {
            MessageBox.Show("this is Assemblyinitialzer");
        }

        [AssemblyCleanup]
        public static void Assemblycleanup()
        {
            MessageBox.Show("this is Assemblycleanup");
        }
    }
}
