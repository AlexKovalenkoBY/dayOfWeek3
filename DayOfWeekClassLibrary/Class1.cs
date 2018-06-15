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
    public class WorkAndHollidays
    {
        DateTime Workdays []= new DateTime();
        //DateTime[] = 
        Workdays = {"14/04/2018"};
   //DateTime[] = Hollydays {"01/05/2018","09/05/2018"};
    }
    public struct ExcludeDay
    {
        DateTime.DayofWeek mydateexcl;
        Boolean ItsWork;
    }
}
