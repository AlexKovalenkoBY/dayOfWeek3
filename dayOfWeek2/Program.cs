using System;
using System.Globalization;
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
            // Test if input arguments were supplied:
            if ((args.Length == 0)||(args[0]!="xml") || (args[0] != "json"))
            {
                System.Console.WriteLine("Please enter a string argument: json or Xml.");
                return 1;
            }
            // var provider = new XmlFileDateExclusionsProvider();
            var provider = new FromJSonFileDateExclusionsProvider();
          //  var jsonprovider = new FromXML2JSonFileDateExclusionsProvider();
          //  jsonprovider.GetExclusionDates();

            Console.Write("Enter the date in the format YY/MM/DD or DD/MM/YYY (or as it will be convenient for you): ");
            String stDate = Console.ReadLine();
           // String myCulture;

            // System.Globalization.CultureInfo myCulture = System.Globalization.CultureInfo(ArgumentNullException);// = new System.Globalization.CultureInfo();


            DateTime Dt = Convert.ToDateTime(stDate, CultureInfo.InstalledUICulture);
           //ateTime Dt = Convert.ToDateTime(stDate);

            MyLogicClass MyObj = new MyLogicClass(provider);
            Boolean BoolResult = MyObj.DayCalc(Dt);
            Console.WriteLine(BoolResult);
            Console.ReadLine();




        }
    }
}