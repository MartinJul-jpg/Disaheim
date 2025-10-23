using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class CourseRepository
    {
        List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            // Implementation for adding a book to the repository
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            Course course= courses.FirstOrDefault(c => c.Name == name);
            return course;
        }

        public double GetTotalValue()
        {
            double total = 0;
            double remainder = 0;
            double hours = 0;
            int hoursInt = 0;
            double price = 0;
            foreach (Course course in courses)
            {
                remainder = course.DurationInMinutes % 60;
                hours = (course.DurationInMinutes + remainder) / 60;
                hoursInt = (int)hours;
                price = hoursInt * 875;

                total = total + price;
            }
            return total;
        }
    }
}
