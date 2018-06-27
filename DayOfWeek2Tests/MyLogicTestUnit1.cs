using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfWeekClassLibrary;

namespace DayOfWeek2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyDaytest1()
        {
            //arrange
            DateTime dtest=DateTime.Parse("01.06.2018");
            Boolean ItsWorkday = true;
            //act 
            MyLogicClass myTestObj = new MyLogicClass();
            bool MyrealDay = myTestObj.DayCalc(dtest);
            //assert
            Assert.AreEqual(ItsWorkday, MyrealDay);
        }
    }
}
