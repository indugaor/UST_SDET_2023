﻿using CaseStudy3;

using System.ComponentModel.Design;
using System.Threading.Channels;
using System.Xml.Serialization;
using static System.Reflection.Metadata.BlobBuilder;
using static CaseStudy3.CustomException.EnrollmentException;

class Program
{
    public delegate void DelegateOne(int id, int idtwo);
    public delegate void DelegateTwo(int cid);

    public static void Main(string[] args)
    {
        try
        {
            int option, option1;


            do
            {
                Console.WriteLine("****The India School****");
                Console.WriteLine("Choose The Option \n 1.Admin \n2.Student");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    int choice, choice1;
                    do
                    {
                        Console.WriteLine("Choose The option:\n1.Add Course\n2.View Report");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Course courses = new Course();
                                Console.WriteLine("Enter The Course Code");
                                courses.CourseCode = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Title");
                                courses.Title = Console.ReadLine();
                                Console.WriteLine("Enter the instructor");
                                courses.Instructor = Console.ReadLine();
                                Console.WriteLine("Enter the no of seats");
                                courses.MaxCount = Convert.ToInt32(Console.ReadLine());

                                Course.courses.Add(courses);
                                Console.WriteLine("Course Added Successfully");
                                break;
                            case 2:

                                break;
                            default:
                                Console.WriteLine("Invalid Option try again Later!!!");
                                break;
                        }
                        Console.WriteLine("Do You Want To Continue Press\n1.Yes\n2.No");
                        choice1 = Convert.ToInt32(Console.ReadLine());
                    } while (choice1 == 1);

                }
                else if (option == 2)
                {
                    int soption, soption1;
                    do
                    {


                        Console.WriteLine("Choose The Menu You Want: \n 1.New Registration" +
                            "\n2.Enroll Course\n3.View Enrolled Course\n4.Withdraw Course \n 5.Exit");
                        soption = Convert.ToInt32(Console.ReadLine());
                        Student student = new Student();
                        Course courses = new Course();

                        switch (soption)
                        {

                            case 1:
                                Console.WriteLine("Enter The Student Id/User Id");
                                student.Id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Name");
                                student.StudName = Console.ReadLine();
                                Console.WriteLine("Enter The Email");
                                student.Email = Console.ReadLine();

                                Student.students.Add(student);
                                Console.WriteLine("Successfully Register!!!");
                                break;
                            case 2:


                                int cid;
                                if (Course.courses.Count != 0)
                                {
                                    Console.WriteLine("***List Of Course Availble In India School***");
                                    foreach (var course in Course.courses)
                                    {

                                        Console.WriteLine($"Course Code:{course.CourseCode}\tCourse Title:{course.Title}" +
                                            $"\tInstructor:{course.Instructor}\tNo:Of Seat:{course.MaxCount}\t");




                                    }
                                    Console.WriteLine("Enter  the Student Id");
                                    int sssid = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter the course code You Want enroll");
                                    cid = Convert.ToInt32(Console.ReadLine());
                                    DelegateOne delegateOne = new DelegateOne(courses.CourseRegistration);
                                    delegateOne(sssid, cid);
                                }
                                else
                                {
                                    Console.WriteLine("No Courses Available!!!");

                                }


                                break;
                            case 3:

                                Console.WriteLine("Enter the Stude Id");
                                int esid = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter The Course Id");
                                int ccid = Convert.ToInt32(Console.ReadLine());

                                var courseObj = Course.courses.Find(x => x.CourseCode == ccid);
                                var EnrolObj = courseObj.Enrollments.Find(x => x.Id == esid);

                                if (EnrolObj != null)
                                {



                                    Console.WriteLine($"Course Code:{courseObj.CourseCode}\tTitle:{courseObj.Title}" +
                                        $"\tInstructor:{courseObj.Instructor}\tStudent Id:{EnrolObj.Id}\tStudent Name:{EnrolObj.StudName}\tEmail:{EnrolObj.Email}");


                                }
                                break;
                            case 4:
                                Console.WriteLine("Enter Your Course Code You Want Withdraw");
                                int eid = Convert.ToInt32(Console.ReadLine());
                                DelegateTwo delegateTwo = new DelegateTwo(courses.CourseWithdrawal);
                                delegateTwo(eid);
                                break;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid option try again!!!");
                                break;
                        }
                        Console.WriteLine("Do You Want To Continue press \n 1.Yes \n 2.No");
                        soption1 = Convert.ToInt32(Console.ReadLine());

                    } while (soption1 == 1);
                }

            } while (true);
        }
        catch (FullException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DuplicateException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

