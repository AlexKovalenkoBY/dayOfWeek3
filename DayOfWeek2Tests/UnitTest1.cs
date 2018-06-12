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

            //вот тут у меня какой-то косяк с видимостью метода...
            Boolean MyrealDay = dayOfWeek2.Program.DayCalc(dtest);
            //assert
            Assert.AreEqual(ItsWorkday, MyrealDay);
        }
    }
}
