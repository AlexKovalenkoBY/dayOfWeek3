using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfWeek2
    {
    class Program
    {
        static Boolean DayCalc(DateTime indata)
        {
            int x = (int)indata.DayOfWeek;
            if ((x==0)||(x==6))
                { return false;}
            else { return true; }
        }

        static void Main(string[] args)
        {
            

            Console.Write("Введите дату в формате ГГ/ММ/ДД или ДД/ММ/ГГГ (или как Вам будет удобно): ");
            String stDate, Result = "", ResultInStr = "";
            Boolean BoolResult;
            stDate = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(stDate);
            
                        
            BoolResult = DayCalc(dt);
          Console.WriteLine(BoolResult);
            Console.ReadLine();

        }
    }
}