using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Threading.Tasks;
  
namespace DayOfWeekClassLibrary
{
    public class MyLogicClass
    {
        private List<DateexClass>  ExclusionDates;
        //constructor 
        public  MyLogicClass (List<DateexClass> exclusiondates) 
        { 
            this.ExclusionDates = exclusiondates;
        }
        public Boolean DayCalc(DateTime indata)
        {
         //проверяем исключения
         //если дата в исключениях, то выводим ответ из исключений
        Boolean BoolResult=false;
                for (int i =0 ;i<3;i++)
                { if (this.ExclusionDates[i].Dayexcl==indata)
                    {
                        if (this.ExclusionDates[i].Flag)
                            return this.ExclusionDates[i].Flag;
                     }
                }            
                    DayOfWeek x = indata.DayOfWeek;
            if ((x == DayOfWeek.Sunday) || (x == DayOfWeek.Saturday))
            { return false; }
            else { return true; }
        }
    }
    [Serializable]
    public class DateexClass
    {
       public  DateTime Dayexcl;
        public Boolean Flag;
        public DateexClass()
        { }
        public DateexClass(DateTime dayexcl, Boolean flag)
        {
            Dayexcl = dayexcl;
            Flag = flag;
        }

    }
    [Serializable]
    public class DateexArrayClass
        {
        public DateexClass[] DateexArray;

        }
 
   
}
