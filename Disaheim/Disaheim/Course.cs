using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        public string Name;
        public int DurationInMinutes;

        public Course(string name)
        {
            this.Name = name;
            DurationInMinutes = 0;
        }

        public Course(string name, int durationInMinutes)
        {
            this.Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            string text = $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
            return text;
        }
    }
}
