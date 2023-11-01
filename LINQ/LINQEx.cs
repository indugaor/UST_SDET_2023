using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQEx
    {
        public void eg1()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("Web Tech");
            courses.Add("Cloud Tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");
            /*
             var result=from c in courses
                        where c.Equals("DBMS")
                        select c;
            */
            // var result=courses.Where(c => c.Equals("DBMS"));
            //var result = courses.Where(c => c.Contains("Tech"));
            //var result = courses.Where(c => c.Contains("Tutorial"));
           /* foreach (var r in result)
            {
                Console.WriteLine(r);
            }*/
        }

        public void eg2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "AA", "CSE"));
            students.Add(new Student(2, "BB", "CSE"));
            students.Add(new Student(3, "CC", "CSE"));
            students.Add(new Student(4, "DD", "CSE"));
            students.Add(new Student(5, "EE", "CSE"));
            students.Add(new Student(6, "FF", "CSE"));

            Student stud =(Student) students.FirstOrDefault(s => s.Id == 3);
            //foreach (var s in stud)
            if (stud != null)
            {
                Console.WriteLine("Student:" + stud.Id + "" + stud.Name + "" + stud.Dept);
            }
            else
            {
                Console.WriteLine("NF");
            }
            
            List<Student> stud2 = (List<Student>)students.FindAll(s => s.Name=="AA" || s.Name=="FF");
            foreach (var s in stud2)
            {
                Console.WriteLine("Student:"+s.Id + "" + s.Name + "" + s.Dept);
            }
           

        }
        public void filteringOfType()
        {
            ArrayList elements= new ArrayList();
            elements.Add(1);
            elements.Add("Two");    
            elements.Add(3);
            elements.Add(4);
            elements.Add("Five");
            // var strings = from e in elements.OfType<string>()
            //             select e;
            //var numbers = from e in elements.OfType<string>()
              //            select e;
            var numbers=elements.OfType<int>();
            var strings=elements.OfType<string>();
            foreach(string str in  strings)
                Console.WriteLine("String:"+str);
            foreach (int num in numbers)
                Console.WriteLine("Number:" + num);

        }
        public void OrderBy()
        {
           // IList<Stu

            //var result = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
        }
    }
}
