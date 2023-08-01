using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProjectFramework1.Attributes
{
    [TestClass]
    public class Expectedconditions
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExpecctedExcen()
        {
            string[] places =new string[] { "Mysore", "Banglore", "Mumbai", "Delhi", "Manali" };
            for(int i = 0; i <= places.Length; i++)
            {
                Console.WriteLine(places[i]);
            }
        }

    }
}
