﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeekClassLibrary;
using System.Collections.Generic;

namespace DayOfWeek2Tests
{
    [TestClass]
    public class MyLogicTest1
    {
        [TestMethod]
        public void My_Daytest1()
        {
            //arrange
            DateTime dtest=DateTime.Parse("01.06.2018");
            Boolean ItsWorkday = true;
            //act 
            var _test_provider = new XmlFileDateExclusionsProvider();
             MyLogicClass myTestObj = new MyLogicClass(_test_provider);
            bool MyrealDay = myTestObj.DayCalc(dtest);
            //assert
            Assert.AreEqual(ItsWorkday, MyrealDay);
        }
    }
}
