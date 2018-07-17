using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace DayOfWeekClassLibrary
{
    public class MyLogicClass
    {
        private IDateExclusionsProvider _dateExclusionsProvider;
        //constructor 
        public MyLogicClass(IDateExclusionsProvider exclusionDatesProvider)
        {
            this._dateExclusionsProvider = exclusionDatesProvider;
        }
        public Boolean DayCalc(DateTime indata)
        {
            //проверяем исключения
            //если дата в исключениях, то выводим ответ из исключений
            // Boolean BoolResult=false;
            List<DateexClass> mylist = this._dateExclusionsProvider.GetExclusionDates();
            for (int i = 0; i < mylist.Capacity; i++)
            {
                if (mylist[i].Dayexcl == indata)
                {
                    return mylist[i].Flag;
                }
            }
            DayOfWeek x = indata.DayOfWeek;
            if ((x == DayOfWeek.Sunday) || (x == DayOfWeek.Saturday))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    [Serializable]
    public class DateexClass
    {
        public DateTime Dayexcl;
        public Boolean Flag;
        public DateexClass()
        {
        }
        public DateexClass(DateTime dayexcl, Boolean flag)
        {
            Dayexcl = dayexcl;
            Flag = flag;
        }
    }
    [Serializable]
  //  [XmlIgnore]
    public class DateexArrayClass
    {

        public DateexClass[] DateexArray;
    }
}
