using System;

namespace DayOfWeekClassLibrary
{
    public class MyLogicClass
    {
        public Boolean DayCalc(DateTime indata)
        {
            DayOfWeek x = indata.DayOfWeek;
            if ((x == DayOfWeek.Sunday) || (x == DayOfWeek.Saturday))
            { return false; }
            else { return true; }
        }
    }
    public class DateexClass
    {
       public  DateTime dayexcl;
        public Boolean flag;
    }
   
}
