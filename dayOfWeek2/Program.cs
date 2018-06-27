using System;
using DayOfWeekClassLibrary;
using System.Collections.Generic;



namespace DayOfWeek2
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int MaxDays=3;
        //DateexClass[] DateExclArray = new DateexClass[3];
        var DateExclArray = new List<DateexClass>(MaxDays);
            DateExclArray.Capacity=MaxDays;
            
            DateExclArray.Add(new DateexClass() {dayexcl = Convert.ToDateTime("01/05/2018"), flag = false} );
            DateExclArray.Add(new DateexClass() {dayexcl = Convert.ToDateTime("03/07/2018"), flag = false} );
            DateExclArray.Add(new DateexClass() {dayexcl = Convert.ToDateTime("07/07/2018"), flag = true} );

           
          Console.Write("Enter the date in the format YY/MM/DD or DD/MM/YYY (or as it will be convenient for you): ");
            String stDate;
            Boolean BoolResult;
            stDate = Console.ReadLine();
            DateTime Dt = Convert.ToDateTime(stDate);
              MyLogicClass MyObj = new MyLogicClass(DateExclArray) ;
            BoolResult = MyObj.DayCalc(Dt);
          
             Console.WriteLine(BoolResult);
            Console.ReadLine();
        }
    }
}