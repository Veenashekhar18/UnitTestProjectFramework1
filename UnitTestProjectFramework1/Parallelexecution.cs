using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
[assembly: Parallelize(Workers =3, Scope=ExecutionScope.MethodLevel)]

namespace UnitTestProjectFramework1
{
    [TestClass]
    [TestCategory("parallelexecution")]
    public class Parallelexecution
    {
        [TestMethod]
       
        public void ParallelExecution()
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Execution num {new DateTime().Millisecond} ");

        }
        [TestMethod]
        [TestCategory("ParallelExecution")]
       // [DoNotParallelize]
        public void Parallelexecution2()
        {
            Thread.Sleep(1000);
            Console.WriteLine("do not parallize");
        }
    }
}
