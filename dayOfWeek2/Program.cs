using System;
using DayOfWeekClassLibrary;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace DayOfWeek2
{
    static class Program
    {
        static void Main(string[] args)
        {
           

            var provider = new XmlFileDateExclusionsProvider();

            Console.Write("Enter the date in the format YY/MM/DD or DD/MM/YYY (or as it will be convenient for you): ");
            String stDate;
            
            stDate = Console.ReadLine();
            DateTime Dt = Convert.ToDateTime(stDate);
              MyLogicClass MyObj = new MyLogicClass(provider) ;
            Boolean BoolResult;
            BoolResult = MyObj.DayCalc(Dt);
          
             Console.WriteLine(BoolResult);
            Console.ReadLine();
        }
    }

}