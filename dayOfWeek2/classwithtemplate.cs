using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayOfWeek2
{
   public abstract class FileDateExclusionsProvider : IDateExclusionsProvider
    {
        protected abstract XmlObjectSerializer CreateSerializer();

        protected abstract string GetFilePath();

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

    public class FromJSonFileDateExclusionsProvider : FileDateExclusionsProvider
    {
        protected override XmlObjectSerializer CreateSerializer()
        {
            return new DataContractJsonSerializer(typeof(DateexArrayClass));
        }

        protected abstract string GetFilePath();//TODO

    }
}
