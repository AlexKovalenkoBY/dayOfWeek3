using DayOfWeekClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UnitTestProject1
{
    class TestExclusionsProvider : IDateExclusionsProvider
    {
        private DateexClass[] _exclusionDates;

        public TestExclusionsProvider(DateexClass[] exclusionDates)
        {
            _exclusionDates = exclusionDates;
        }

        public List<DateexClass> GetExclusionDates()
        {
            return new List<DateexClass>(_exclusionDates);
        }
    }

    
}
