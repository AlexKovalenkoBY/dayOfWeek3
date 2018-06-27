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
            //  people.Add(new Person() { Name = "Том" });
            DateExclArray.Add(new DateexClass() {dayexcl = Convert.ToDateTime("01/05/2018"), flag = false} );
            DateExclArray.Add(new DateexClass() {dayexcl = Convert.ToDateTime("03/07/2018"), flag = false} );
            DateExclArray.Add(new DateexClass() {dayexcl = Convert.ToDateTime("07/07/2018"), flag = true} );

           
          Console.Write("Enter the date in the format YY/MM/DD or DD/MM/YYY (or as it will be convenient for you): ");
            String stDate;
            Boolean BoolResult;
            stDate = Console.ReadLine();
            DateTime Dt = Convert.ToDateTime(stDate);
              MyLogicClass MyObj = new MyLogicClass() ;
            BoolResult = MyObj.DayCalc(Dt);
            //проверяем исключения
                for (int i =0 ;i<3;i++)
                { if (DateExclArray[i].dayexcl==Dt)
                    {
                        if (DateExclArray[i].flag)
                            BoolResult =DateExclArray[i].flag;
                         else BoolResult=BoolResult&DateExclArray[i].flag;
                    }
                }
             Console.WriteLine(BoolResult);
            Console.ReadLine();
        }
    }
}