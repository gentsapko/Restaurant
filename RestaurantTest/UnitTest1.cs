﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantAutomation;

namespace RestaurantTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Class1();
            c.Go();
        }
    }
}
