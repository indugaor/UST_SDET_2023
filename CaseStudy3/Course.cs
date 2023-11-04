using CaseStudy3.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CaseStudy3.CustomException.EnrollmentException;

namespace CaseStudy3
{
    internal class Course : IEnrollment
    {
        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }
        public int? MaxCount { get; set; }
        public static List<Course> courses = new List<Course>();
        public List<Student> Enrollments = new List<Student>();

        public void CourseRegistration(int id, int sid)
        {
            var data = courses.Find(x => x.CourseCode == id && x.MaxCount >= x.Enrollments.Count);
            var nameCheck = Student.students.Find(x => x.Id == sid);
            var s = data.Enrollments.Find(x => x.Id == sid);

            if (data == null)
            {
                throw new FullException(EnrollmentException.Message["One"]);
            }
            else if (s != null)
            {
                throw new DuplicateException(EnrollmentException.Message["Two"]);
            }
            else
            {
                data.Enrollments.Add(nameCheck);
                Console.WriteLine("Successfully Added!!!");
            }

        }

        public void CourseWithdrawal(int id)
        {
            var data = courses.Find(x => x.CourseCode == id);
            var removeEnroll = data.Enrollments.RemoveAll(x => x.Id == id);
            if (removeEnroll != null)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Unsuccess");
            }
        }

    }
}
