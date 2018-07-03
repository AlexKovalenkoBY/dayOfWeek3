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
       public  DateTime Dayexcl { get; set; }
        public Boolean Flag { get; set; }
        public DateexClass()
        { }
        public DateexClass(DateTime dayexcl, Boolean flag)
        {
            Dayexcl = dayexcl;
            Flag = flag;
        }

    }
  /* public class MySerializeClass
        {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Day
        {
            private string dateField;
            private bool flagField;

            /// <remarks/>
            public string Date 
            {   get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            public bool Flag
            {
                get
                {
                    return this.flagField;
                }
                set
                {
                    this.flagField = value;
                }
            }
        }


    }*/
   
}
