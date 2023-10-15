﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabukovDV.Sprint2.Task3.V26.Lib;

namespace Tyuiu.ShabukovDV.Sprint2.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-12);
            Assert.AreEqual(20736.25, res, 0.001);
        }
    }
}
