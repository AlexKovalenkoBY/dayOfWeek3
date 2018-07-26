using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace DayOfWeekClassLibrary
{ 
    public class XmlFileDateExclusionsProvider : IDateExclusionsProvider
    {
        // implementation}
        public List<DateexClass> GetExclusionDates()
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(DateexArrayClass));
            DateexArrayClass excldates;
            using (FileStream fs = new FileStream("excldates.xml", FileMode.Open))
            {
                excldates = (DateexArrayClass)formatter.Deserialize(fs); ////!!

            }
            return new List<DateexClass>(excldates.DateexArray);
        }

    }
    public class FromXML2JSonFileDateExclusionsProvider 
    {
        // implementation}
        public List<DateexClass> GetExclusionDates()
        {
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(DateexArrayClass));
            DateexArrayClass excldates;
            using (FileStream fs = new FileStream("excldates.xml", FileMode.Open))
            {
                excldates = (DateexArrayClass)formatter.Deserialize(fs); ////!!
            }
            //конвертор XML2json
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(DateexArrayClass));
            // Создаём поток
            using (FileStream buffer = File.Create("d:\\tmp\\excldates.json"))               
            {
                // Сериализуем объект
                jsonSerializer.WriteObject(buffer, excldates);
            }
            return new List<DateexClass>(excldates.DateexArray);
        }

    }
    public class FromJSonFileDateExclusionsProvider : IDateExclusionsProvider
    {
        // implementation}
        public List<DateexClass> GetExclusionDates()
        {
            // передаем в конструктор тип класса
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(DateexArrayClass));
            DateexArrayClass excldates;
            using (FileStream fs = new FileStream("d:\\tmp\\excldates.json", FileMode.Open))
            {
                excldates = (DateexArrayClass)formatter.ReadObject(fs); ////!!
            }
            
            return new List<DateexClass>(excldates.DateexArray);
        }
    }
}