using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Helpers
{
    public static class DateTimeOffsetExtensions
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffSet)
        {
            var currentDate = DateTime.UtcNow;
            int age = currentDate.Year - dateTimeOffSet.Year;

            if (currentDate < dateTimeOffSet.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
