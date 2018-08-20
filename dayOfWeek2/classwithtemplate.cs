using DayOfWeekClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime;
using System.IO;
using System.Runtime.Serialization.Json;

namespace dayOfWeek2
{
   public abstract class FileDateExclusionsProvider : IDateExclusionsProvider
    {
        protected abstract XmlObjectSerializer CreateSerializer(); //абстрактный метод

        protected abstract string GetFilePath(); //абстрактный метод

        // Template Method Pattern!!!
        public List<DateexClass> GetExclusionDates()
        {
            // передаем в конструктор тип класса
            XmlObjectSerializer formatter = CreateSerializer();
            DateexArrayClass excldates;
            using (FileStream fs = new FileStream(GetFilePath(), FileMode.Open))
            {
                excldates = (DateexArrayClass)formatter.ReadObject(fs); ////!!
            }

            return new List<DateexClass>(excldates.DateexArray);
        }
    }
    //
    public class FromJSonFileDateExclusionsProvider : FileDateExclusionsProvider
    {
        protected override XmlObjectSerializer CreateSerializer()
        {
            return new DataContractJsonSerializer(typeof(DateexArrayClass));
        }

        protected override string GetFilePath() //смущает меня protected abstract....
        {
            return "d:\\tmp\\excldates.json";
           
        }
    }
    public class FromXMLFileDateExclusionsProvider : FileDateExclusionsProvider
    {
        protected override XmlObjectSerializer CreateSerializer()
        {
            return new DataContractJsonSerializer(typeof(DateexArrayClass));
        }

        protected override string GetFilePath() //смущает меня protected abstract....
        {
           return "d:\\tmp\\excldates.xml";

                               
           
        }
    }
}
    

