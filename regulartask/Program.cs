﻿/*
Console.WriteLine("Enter 2 numbers");
int num1, num2, ans;
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
ans = num1 + num2;
Console.WriteLine(ans);
*/
/*
string s1 = "";
string s2 = "";
string s3;
s1 = Console.ReadLine();
s2 = Console.ReadLine();
s3 = s1 + " " + s2;
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());
Console.WriteLine(s2.Substring(3));
string[] s = s3.Split(' ');
for (int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);
*/
/*
int x = 5;
switch (x)
{
    case 1:
        Console.WriteLine();
        break;
    case 2:
        Console.WriteLine();
        break;
    case 3:
        Console.WriteLine();
        break;
    default:
        Console.WriteLine();
        break;

}
*/
/*
//driver
using Basic_Programs;
Calculation calculation = new Calculation();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
 double res=calculation.Add(num1,num2);
Console.WriteLine(res);
*/
/*
//using driver class
using Basic_Programs;
int consumernumber = Convert.ToInt32(Console.ReadLine());

Electricity electricity1 = new(consumernumber, 9000, 9300, "XX");
Console.WriteLine(electricity1.CalculateBill());
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.consumername);
Electricity electricity2 = new(23456, 9000, 10000, "XX");
Console.WriteLine(electricity2 .CalculateBill());
Console.WriteLine(electricity2.CalculateBill());
Console.WriteLine(electricity2.consumernumber);
*/
/*
//driver
using Basic_Programs;
Employee employee = new(111, "AA", "IT", 10000);
Console.WriteLine("Emp Id: {0} \n Name : {1} \n" + "Dept : {2} \n Basic Pay: {3} ",
employee.Eid,
employee.Ename,
employee.Dept, employee.Basicpay,
employee.CalculateSalary);
Console.WriteLine("Net Pay: {0}", employee.CalculateSalary);
*/
/*
//driver 
using Basic_Programs;

ArraysEx arraysEx = new();
arraysEx.Ja();
*/
//driver 
using Basic_Programs;
using Basic_Programs.ExceptionMess;
/*
StudentMarks marks= new ();
marks.RollNo = 1000;
marks.StudName = "Indu";
marks.Mark1 = 99;
marks.Mark2 = 87;
marks.Mark3 = 97;

marks.DisplayStudentDetails();
Console.WriteLine("Total"+marks.CalculateTotal());
Console.WriteLine("Average"+marks.CalculateAverage());
*/
/*
StudentGrade grade = new();
grade.RollNo = 1000;
grade.StudName = "Indu";
grade.Mark1 = 99;
grade.Mark2 = 87;
grade.Mark3 = 97;

grade.DisplayStudentDetails();
Console.WriteLine("Total" + grade.CalculateTotal());
Console.WriteLine("Average" + grade.CalculateAverage());
Console.WriteLine("Grade" + grade.CalculateGrade());
*/
/*
Console.WriteLine("1. TS 2. NTS");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:


        TeachingStaff ts = new TeachingStaff();
        ts.Staffid = 111;
        ts.Name = "TS1";
        ts.Dept = "CS";
        ts.Specializations = "Os,DBMS,DS";
        ts.Sem = 4;
        ts.DisplayTStaffDetails();
        ts.DisplayStaffDetails();
        break;

case 2:
        

NonTeachingStaff nts = new NonTeachingStaff();
    
    nts.Staffid =999;
    nts.Name = "NTS1";
    nts.Dept = "Admin";
    nts.Responsibilities = "Att,Sal";
    nts.Experence = 4;
        nts.DisplayStaffDetails();
    
    nts.DisplayNTStaffDetails();
    break;
}
*/
/*
EV ev = new();
ev.Vehnum = 444;
ev.Brand = "XX";
ev.Model = "AA";
ev.Disp();
Console.WriteLine(ev.setTypeForVeh());

PV pv = new();
pv.Vehnum = 234567;
pv.Brand = "YY";
pv.Model = "BB";
pv.Disp();
Console.WriteLine(pv.setTypeForVeh());
*/
/*
Doctor doc = new Doctor();
doc.AddNewDoctor(1234,"AA");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(9876,"BB");
doc.DisplayDoctorDetails();
doc.BookApp(9876, "XX");
doc.DelApp("XX");
*/
/*
BankDetails bank = new BankDetails(1234, 1234567890L, "AA", "Inactive");
Console.WriteLine("1.Custid 2.Accno 3.Name");
int ch = Convert.ToInt32(Console.ReadLine());
bank.WelcomeMessage();
switch (ch)
{
    case 1:
        Console.WriteLine("Custid : ");
        bank.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;
    case 2:
        Console.WriteLine("Accno : ");
        bank.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
        break;

    case 3:
        Console.WriteLine("Name : ");
        bank.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
        break;
    default: Console.WriteLine("Enter bet 1-3");
        break;
}
*/
/*
NGC nGC = new NGC();
nGC.ArrayListHandling();
nGC.SLHandling();
nGC.QueueHandling();
nGC.SLHandling();
nGC.HThandling();
*/
/*
Basic_Programs.GC gc = new Basic_Programs.GC();
gc.ListHandling();
gc.Dicthandling();
*/
/*

ExcepHandling excep=new ExcepHandling(10,107);

try
{
    excep.NumCheck();
}
catch(Num1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    excep.NumCheck2();


}
catch(Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}

/*
try
{
    excep.Divide();


  

}
catch (ArithmeticException ex)
{
    //  Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
    //Console.WriteLine(ex.Source);
    Console.WriteLine(MyExceptions.exmesslist["Div 0"]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.exmesslist["IOR"]);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.exmesslist["UE"]);
}
finally
{
    Console.WriteLine("Done");
}

 */

FileOperations fo=new FileOperations();
//fo.CreateFile();
//fo.WriteData();
//fo.ReadData();
//fo.CopyMoveFile();
//fo.DeleteFile();
fo.FileProperties();