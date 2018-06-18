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
            const int MaxDays=3;
        DateexClass[] DateExclArray = new DateexClass[3];
            for (int i=0; i<MaxDays;i++)
                {
                    DateExclArray[i]= new DateexClass();
                }
            //---------------
            //DateexClass DateExclArray[0]= new DateexClass();
            DateExclArray[0].dayexcl = Convert.ToDateTime("01.05.2018");
            DateExclArray[0].flag = false;
            //--------------
           // DateexClass DateExclArray[1]= new DateexClass();
            DateExclArray[1].dayexcl = Convert.ToDateTime("03/07/2018");
            DateExclArray[1].flag = false;
            //--------------------
            //DateexClass DateExclArray[1]= new DateexClass();
            DateExclArray[2].dayexcl = Convert.ToDateTime("07/07/2018");
            DateExclArray[2].flag = true;

          Console.Write("Введите дату в формате ГГ/ММ/ДД или ДД/ММ/ГГГ (или как Вам будет удобно): ");
            String stDate;
            Boolean BoolResult;
            stDate = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(stDate);

            MyLogicClass MyObj = new MyLogicClass() ;
            BoolResult = MyObj.DayCalc(dt);
            //проверяем исключения
                for (int i =0 ;i<3;i++)
                { if (DateExclArray[i].dayexcl==dt)
                    { BoolResult=BoolResult&DateExclArray[i].flag;}
                }
             Console.WriteLine(BoolResult);
            Console.ReadLine();

        }
    }
}