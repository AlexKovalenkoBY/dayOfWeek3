using System;
using DayOfWeekClassLibrary;


namespace dayOfWeek2
{
    public class Program
    {
        /*public Boolean DayCalc(DateTime indata)
        {
            /*int x = (int)indata.DayOfWeek;
            if ((x == 0) || (x == 6))
            { return false; }
            else { return true; }

           */
            
           /* DayOfWeek x = indata.DayOfWeek;
                if ((x==DayOfWeek.Sunday)||(x==DayOfWeek.Saturday))
                    { return false;}
                else { return true; }
             
        }*/
        static void Main(string[] args)
        {
          Console.Write("Введите дату в формате ГГ/ММ/ДД или ДД/ММ/ГГГ (или как Вам будет удобно): ");
            String stDate;
            Boolean BoolResult;
            stDate = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(stDate);

            MyLogicClass MyObj = new MyLogicClass() ;
            BoolResult = MyObj.DayCalc(dt);
          Console.WriteLine(BoolResult);
            Console.ReadLine();

        }
    }
}