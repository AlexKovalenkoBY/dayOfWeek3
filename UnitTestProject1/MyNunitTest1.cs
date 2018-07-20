using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeekClassLibrary;
using System.Globalization;
using NUnit.Framework;
using NSubstitute;
using UnitTestProject1;
using System.Collections.Generic;

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
        [Test]
        public void MyNUnitTestMetod2()
        {
            
            var dateprovider = Substitute.For<IDateExclusionsProvider>(); //здесь должен быть интерфейс?? 
            List<DateexClass> testdates = new List<DateexClass>();
            DateTime dtest = DateTime.Parse("01.06.2018", CultureInfo.InvariantCulture);
            DateexClass oneday = new DateexClass(dtest,true);


            testdates.Add(oneday);

            dateprovider.GetExclusionDates().Returns(testdates);

            MyLogicClass myTestObj = new MyLogicClass(dateprovider);
            bool MyrealDay = myTestObj.DayCalc(dtest);
            //assert
            Boolean ItsWorkday = true;
            Assert.AreEqual(ItsWorkday, MyrealDay);

            //Assert.That(datecontrol.DayCalc(01 / 08 / 2018, false), Is.EqualTo(false);
        }
    }
    

}

