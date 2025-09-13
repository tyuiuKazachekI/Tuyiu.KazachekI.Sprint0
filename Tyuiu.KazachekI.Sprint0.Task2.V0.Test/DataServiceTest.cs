using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KazachekI.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KazachekI.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Иван";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Иван", res);
        }
    }
}
