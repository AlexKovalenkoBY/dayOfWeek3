using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeekClassLibrary;
using System.Collections.Generic;

namespace DayOfWeek2Tests
{
    [TestClass]
    public class MyLogicTest1
    {
        [TestMethod]
        public void MyDaytest1()
        {
            //arrange
            DateTime dtest=DateTime.Parse("01.06.2018");
            Boolean ItsWorkday = true;
            //act 
           /* const int MaxDays = 3;
            var DateExclArray = new List<DateexClass>(MaxDays);
            DateExclArray.Add(new DateexClass() { Dayexcl = Convert.ToDateTime("01/05/2018"), Flag = false });
            DateExclArray.Add(new DateexClass() { Dayexcl = Convert.ToDateTime("03/07/2018"), Flag = false });
            DateExclArray.Add(new DateexClass() { Dayexcl = Convert.ToDateTime("07/07/2018"), Flag = true });
            */
            var _test_provider = new XmlFileDateExclusionsProvider();

            MyLogicClass myTestObj = new MyLogicClass(_test_provider);
            bool MyrealDay = myTestObj.DayCalc(dtest);
            //assert
            Assert.AreEqual(ItsWorkday, MyrealDay);
        }
    }
}
