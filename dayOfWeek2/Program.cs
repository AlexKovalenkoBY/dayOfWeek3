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
            //переписать кодирвоку!!! 
            //Console.OutputEncoding = Encoding.GetEncoding(1251);

            Console.Write("Введите дату в формате ГГ/ММ/ДД или ДД/ММ/ГГГ (или как Вам будет удобно): ");
            String stDate, Result = "", ResultInStr = "";
            Boolean BoolResult;
            stDate = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(stDate);
            ResultInStr = Convert.ToString(dt.DayOfWeek);
            

            switch (ResultInStr)
            {
                case "Monday":
                    Result = "Понедельник"; break;
                case "Tuesday":
                    Result = "Вторник"; break;
                case "Wednesday":
                    Result = "Среда"; break;
                case "Thursday":
                    Result = "Четверг"; break;
                case "Friday":
                    Result = "Пятница"; break;
                case "Saturday":
                    Result = "Суббота"; break;
                case "Sunday":
                    Result = "Воскресенье"; break;
                default:
                    Console.WriteLine($"Введеннео значение не определено ({ResultInStr})");
                    break;
            }
            // Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
            Console.WriteLine("Введенная Вами дата приходится на " + Result);
            BoolResult = DayCalc(dt);
          Console.WriteLine(BoolResult);
            Console.ReadLine();

        }
    }
}