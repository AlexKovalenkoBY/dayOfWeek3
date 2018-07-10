using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace DayOfWeekClassLibrary
{ 
    public class XmlFileDateExclusionsProvider : IDateExclusionsProvider
    {
        // implementation}
        public List<DateexClass> GetExclusionDates()
        {
            const int MaxDays = 3;
            //DateexClass[] DateExclArray = new DateexClass[3];
            var DateExclArray = new List<DateexClass>(MaxDays);
            DateExclArray.Capacity = MaxDays;

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
}