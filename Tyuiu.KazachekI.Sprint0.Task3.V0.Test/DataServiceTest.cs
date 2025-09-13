using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tyuiu.KazachekI.Sprint0.Task3.V0.Test
{
    using Tyuiu.KazachekI.Sprint0.Task3.V0.Lib;
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
