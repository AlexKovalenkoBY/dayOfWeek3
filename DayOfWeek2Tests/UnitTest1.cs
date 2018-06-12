using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DayOfWeek2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MyDaytest1()
        {
            //arrange
            DateTime dtest="01.06.2018";
            Boolean ItsWorkday = true;
            //act 
            dayOfWeek2.Program myTestOj = new dayOfWeek2.Program();
            bool MyrealDay = myTestOj.DayCalc(dtest);
            //assert
            Assert.AreEqual(ItsWorkday, MyrealDay);
        }
    }
}
