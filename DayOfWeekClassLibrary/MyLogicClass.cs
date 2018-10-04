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
 /*   [Serializable]*/
    public class DateexClass
    {
        public DateTime Dayexcl;
        public Boolean Flag;
        public DateexClass() //constructor
        {
        }
        public DateexClass(DateTime dayexcl, Boolean flag)
        { //
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
 
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class DateexArray
    {

        private DateexArrayDateexClass[] dateexClassField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateexClass")]
        public DateexArrayDateexClass[] DateexClass
        {
            get
            {
                return this.dateexClassField;
            }
            set
            {
                this.dateexClassField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DateexArrayDateexClass
    {

        private System.DateTime dayexclField;

        private bool flagField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime Dayexcl
        {
            get
            {
                return this.dayexclField;
            }
            set
            {
                this.dayexclField = value;
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





}
