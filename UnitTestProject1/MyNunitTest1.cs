using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeekClassLibrary;
using System.Globalization;
using NUnit.Framework;
using UnitTestProject1;

namespace MyNunitTestSpace
{
    public class MyNunitTest1
    {
        [Test]
        public void MyNunitTestMetod1()
        {
            //arrange
            DateTime dtest = DateTime.Parse("01.06.2018", CultureInfo.InvariantCulture);
            Boolean ItsWorkday = true;
            //act 
            var _test_provider = new TestExclusionsProvider(new[] { new DateexClass(dtest, true) });

            //
            MyLogicClass myTestObj = new MyLogicClass(_test_provider);
            bool MyrealDay = myTestObj.DayCalc(dtest);
            //assert
            Assert.AreEqual(ItsWorkday, MyrealDay);


        }
    }
}
