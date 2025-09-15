﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KazachekI.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KazachekI.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var number = new int[] {1, 2, 3, 4, 5};
            var res = DataService.AdditionArray(number);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckSubstractionArrayValid()
        {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubtractionArray(number);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckMultArrayValid() {
            var number = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(number);
            Assert.AreEqual(120, res);
        }

    }
    }
