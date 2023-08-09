using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace UnitTestProjectFramework1
{
    [TestClass]
    public class Annotations1 : AssemblyTest
    {
       

        [ClassInitialize]
        public static void ClassIni(TestContext context)
        {
            MessageBox.Show("this is class initialize");
        }

        

        [TestInitialize]
        public void Testinitialize()
        {
            
            MessageBox.Show("this is test initialize");
        }

        [TestCleanup]
        public void Testcleanup(TestContext context)
        {
            MessageBox.Show("this is test cleanup");
        }



        [ClassCleanup]
        public static void Classcleanup()
        {
            MessageBox.Show("this is class cleanup");
        }

             
         [TestMethod]
        public void Testmethod()
        {
            MessageBox.Show("this is test method");
        }

     
    }
}
