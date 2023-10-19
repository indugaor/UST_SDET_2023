/*
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
//driver 
using Basic_Programs;

ArraysEx arraysEx = new();
arraysEx.Ja();




