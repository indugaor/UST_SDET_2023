﻿// See https://aka.ms/new-console-template for more information
using regular;
using regular.UserException;
/*
Student obj = new Student(90,87,78);
obj.CalculateAverage(); 
*/

/*
Product[] p1 = new Product[3];
p1[0] = new("TV", 25000, 1);
p1[1] = new("FRIDGE", 50000, 2);
p1[2] = new("AC", 10000000, 3);
foreach (var item in p1)
{
    Console.WriteLine("product name:" + item.ProductName);
    Console.WriteLine("product price:" + item.Price);
    Console.WriteLine("product quantity " + item.Quantity);
    Console.WriteLine("total price" + item.ProductValue());
} 
*/
/*

using regular;
using regular;
Students[] students = new Students[]
{

 new("Indu", new double[] {89,80,80}, 'A'),
 new("Keerthi", new double[] {90,99,90}, 'B'),
 new("Raju", new double[] {77,79,70}, 'C'),



};
foreach (Students item in students)
{
    Console.WriteLine($"Student Name is :{item.Name}");
    Console.WriteLine($"Student Grade is: {item.Grade}");
    double[] marks = new double[3];
    double total = 0;
    Console.WriteLine("Marks of student is:\t");
    for (int i = 0; i < marks.Length; i++)
    {
        marks[i] = item.Marks[i];
        total = total + marks[i];
        Console.WriteLine(marks[i]);
    }
    Console.WriteLine($"Total Marks is:{total}");
    Console.WriteLine($"Average Marks is: {item.CalculateAverage()}");
    Console.WriteLine(item.GetMarksSummary());
}
*/
/*
Console.WriteLine("Choose");
Console.WriteLine("1 -> DigitalProduct\n 2->ElectronicsProduct\n " +
    "3-> ClothingProduct");
switch (Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        DigitalProduct digitalProduct = new(5, "camera", 10000, 6, "MP4");
        digitalProduct.DisplayProduct();
        digitalProduct.ElectronicsProductDisplay();
        digitalProduct.DisplayDigitalProduct();
        break;
    case 2:
        ElectronicsProduct electronicsProduct = new(5, "fan", 870, 8);
        electronicsProduct.DisplayProduct();
        electronicsProduct.ElectronicsProductDisplay();
        break;
    case 3:
        ClothingProduct clothingProduct = new("Dress", 500, 4, "XL");
        clothingProduct.DisplayProduct();
        clothingProduct.DisplayClothing();
        break;
    default:
        Console.WriteLine("Please check the number you have entered");
        break;


}
*/
//Employee employee = new("ab", "cd", 23, 22);
//employee.DisplayInfo();
/*
Circle circle = new Circle();
circle.Radius = 5;
circle.Draw();
Console.WriteLine("Area : " + circle.CalculateArea());
Console.WriteLine("Perimeter: " + circle.CalculatePerimeter());

Rectangle rectangle = new Rectangle();
rectangle.Length = 10;
rectangle.Breadth = 20;
rectangle.Draw();
Console.WriteLine("Area: " + rectangle.CalculateArea());
Console.WriteLine("Perimeter: " + rectangle.CalculatePerimeter());
*/
/*
InsurancePolicy policy = new InsurancePolicy("Auto Insurance", 12345, 700.00);
Console.WriteLine("Initial Policy Details:");
policy.DisplayPolicyDetails();
Console.WriteLine();
policy.RenewPolicy(700.00);
Console.WriteLine();
policy.RenewPolicy();
Console.WriteLine();
Console.WriteLine("Final Policy Details:");
policy.DisplayPolicyDetails();
*/
/*
InsurancePolicies lifeInsurance = new LifeInsurance("Life Policy", 1, 25);
InsurancePolicies carInsurance = new CarInsurance("Car Policy", 2, "SUV");
Console.WriteLine("Life Insurance Policy Details:");
lifeInsurance.DisplayPolicyDetails();
Console.WriteLine("\n Car Insurance policy Details:");
carInsurance.DisplayPolicyDetails();
*/
/*
Customer customer = new Customer();
List<Customer> customerArray = new List<Customer>
{
new(1, "Indu", "4848", 1000),
new(2, "Keerthi", "8484", 2000),
new(3, "Raju", "5353", 3000)
};

foreach (Customer cust in customerArray)
{
    Console.WriteLine("Customer Name: " + cust.Name +
    " Customer ID : " + cust.CustomerId + " Phone Number: " +
    cust.PhoneNumber + " Balance : " + cust.Balance);
}
bool IsCustAvail = false;

foreach (Customer cust in customerArray)
{
    if (customer.SearchCustomer("8484", cust))
    {
        IsCustAvail = true;
        Console.WriteLine("Customer Name: " + cust.Name + " Balance: " +
        cust.Balance);
        break;
    }
}

if (!IsCustAvail)
{
    Console.WriteLine("Customer not found");
}

/*
List<CallRecord> callRecords = new List<CallRecord>()
{
    new(12,"123456","4 min"),
    new(34,"123456","6 min"),
    new(56,"1234","8 min")

};

foreach(CallRecord call in callRecords)
{
    Console.WriteLine("Call Id: "+call.CallID+" Phone Number: "+call.PhoneNumber+
        " CallTime: "+call.CallTime);
    
}
foreach(CallRecord calls in callRecords)
{
    calls.CallHistory(calls);
       
}

Dictionary<string, int> callCount = new Dictionary<string, int>();
foreach(CallRecord calls in callRecords)
{
    if (callCount.ContainsKey(calls.PhoneNumber))
    {
        callCount[calls.PhoneNumber]++;
    }
    else
    {
        callCount[calls.PhoneNumber] = 1;
    }
}
foreach(var i in callCount)
{
    Console.WriteLine(" Phone Number: "+i.Key+ " - Total Calls: "+ i.Value);
}
*/
/*
try
{
    Patient patient1 = new(11, "aa", 25, "diabetics");
    patient1.AddPatient(patient1);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    Patient patient2 = new(11, "aa", 125, "diabetics");
    patient2.AddPatient(patient2);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
*/
/*
try
{
    MedicalRecord medicalRecord = new MedicalRecord(11, "Sam", 25, "HeadAche", 101, 5000);
    medicalRecord.AddMedicalRecord(medicalRecord);
}
catch (InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}

try
{
    MedicalRecord medicalRecord1 = new MedicalRecord(100, "", 25, "", 101, 5000);
    medicalRecord1.AddMedicalRecord(medicalRecord1);
}
catch (InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}

try
{
    MedicalRecord medicalRecord2 = new MedicalRecord(10, "Sil", 25, "Fever", 101, -5000);
    medicalRecord2.AddMedicalRecord(medicalRecord2);
}
catch (InvalidMedicalRecordException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidPatientDataException e)
{
    Console.WriteLine(e.Message);
}
*/

Console.WriteLine("Choose");
Console.WriteLine("1->Add Patient\n2->View Patient\n 3-> exit");
int ch = Convert.ToInt32(Console.ReadLine());
Patient patient = new Patient(12, "aa", 24, "diabetics");
switch (ch)
{
    case 1:

        patient.AddPatientToFile(patient);
        break;
    case 2:
        patient.ReadPatientDetailsFromFile();
        break;
    case 3:
        Console.WriteLine("You got exited from execution");
        break;
    default:
        Console.WriteLine("Please check the number");
        break;
}
/*
MedicalHistory medicalHistory = new MedicalHistory();
medicalHistory.RecordId = 11;
medicalHistory.PatientId = 102;
medicalHistory.Description = " Paracetamol for 2 days";
medicalHistory.Date = DateTime.UtcNow;


Console.WriteLine("Choose");
Console.WriteLine("1->Add Medical History\n2->View Medical History\n 3-> exit");
int ch = Convert.ToInt32(Console.ReadLine());
switch (ch)
{
    case 1:

        medicalHistory.AddMedicalHistoryToFile(medicalHistory);
        break;

    case 2:
        Console.WriteLine("Enter the Patient Id to read");
        medicalHistory.ReadMedicalHistoryFromFile(Convert.ToInt32(Console.ReadLine()));
        break;
    case 3:
        Console.WriteLine("You got exited from execution");
        break;
    default:
        Console.WriteLine("Please check the number");
        break;
}
*/

