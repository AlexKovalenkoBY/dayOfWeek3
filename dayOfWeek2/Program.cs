using System;
using DayOfWeekClassLibrary;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



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
            
           /* DateExclArray.Add(new DateexClass() {Dayexcl = Convert.ToDateTime("01/05/2018"), Flag = false} );
            DateExclArray.Add(new DateexClass() {Dayexcl = Convert.ToDateTime("03/07/2018"), Flag = false} );
            DateExclArray.Add(new DateexClass() {Dayexcl = Convert.ToDateTime("07/07/2018"), Flag = true} );
*/
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(DateexArrayClass));
            using (FileStream fs = new FileStream("excldates.xml", FileMode.Open))
            {
                var excldates = (DateexArrayClass)formatter.Deserialize(fs);

                foreach (DateexClass p in excldates.DateexArray)
                {
                    Console.WriteLine("дата: {0} --- флаг: {1} ", p.Dayexcl, p.Flag);
                }
            }
            Console.ReadLine();
            Console.Write("Enter the date in the format YY/MM/DD or DD/MM/YYY (or as it will be convenient for you): ");
            String stDate;
            
            stDate = Console.ReadLine();
            DateTime Dt = Convert.ToDateTime(stDate);
              MyLogicClass MyObj = new MyLogicClass(DateExclArray) ;
            Boolean BoolResult;
            BoolResult = MyObj.DayCalc(Dt);
          
             Console.WriteLine(BoolResult);
            Console.ReadLine();
        }
    }

}