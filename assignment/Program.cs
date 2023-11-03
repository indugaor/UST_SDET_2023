﻿// See https://aka.ms/new-console-template for more information
using regular;
using regular.UserException;
using System.ComponentModel.Design;
using System.Threading;
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

/*

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

*/
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



/*

HotelRoom hotel = new HotelRoom(401, "Double", true);
RoomReservation<HotelRoom> room = new();

room.BookRoom(hotel);
Console.WriteLine("Hotel Room booked Successfully");
Console.WriteLine("Details are :");
string? status;
foreach (var item in RoomReservation<HotelRoom>.values)
{
    if (item.IsBooked)
        status = "Engaged";
    else
        status = "Not Engaged";
    Console.WriteLine("Room Number:{0} Room Type:{1} Status:{2} ", item.RoomNumber, item.RoomType, status);
}
Console.WriteLine("Enter the room number for canceling:");
int num = Convert.ToInt32(Console.ReadLine());
var roomNum = HotelRoom.GetRoom(num);
if (roomNum != null)
{
    room.CancelRoom(roomNum);
    Console.WriteLine("Room is canceled");
}
else
{
    Console.WriteLine("Room doesn't exist");
}
*/



/*
    Inventory<string> inventory = new Inventory<string>();
int choice, option;
do
{
    Console.WriteLine("Choose The Menu");
    Console.WriteLine("1.Add Product\n2.Update Product\n3.RemoveProduct\n4.Search ProductById\n5.Search Product By Name");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Product Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The ProductName");
            string? productname = Console.ReadLine();
            Console.WriteLine("Enter The Price");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity in stock");
            int qty = Convert.ToInt32(Console.ReadLine());
            inventory.AddProduct(new Products<string>(id, productname, price, qty));
            break;
        case 2:
            Console.WriteLine("Enter the product id Do You want update");
            int proid = Convert.ToInt32(Console.ReadLine());
            var prId = inventory.FindProductById(proid);
            if (prId != null)
            {
                Console.WriteLine("Enter the Product Name");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the price");
                double pric = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the qty");
                int qt = Convert.ToInt32(Console.ReadLine());
                inventory.UpdateProduct(proid, name, pric, qt);
                Console.WriteLine("Successfully Updated");

            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }

            break;
        case 3:
            Console.WriteLine("Enter the product Id Do You Want Delete");
            int ids = Convert.ToInt32(Console.ReadLine());
            var data = inventory.FindProductById(ids);
            if (data != null)
            {
                inventory.DeleteProduct(ids);
                Console.WriteLine("Product Deleted Success!!!!");
            }
            else
            {
                Console.WriteLine("No Product available!!!");
            }
            break;
        case 4:
            Console.WriteLine("View Product BY Id");
            Console.WriteLine("Enter The Product Id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Products<string> pro = inventory.FindProductById(pid);
            if (pro != null)
            {
                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.ProductName}" +
                    $"\nPrice:{pro.Price}\nQuantity:{pro.QuantityInStock}");
            }
            else
            {
                Console.WriteLine("No Product Available");
            }



            break;
        case 5:
            Console.WriteLine("Search Product By Name");
            string? proname = Console.ReadLine();
            List<Products<string>> dat = inventory.FindProductByName(proname);
            if (dat != null)
            {
                foreach (Products<string> p in dat)
                {
                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.ProductName}" +
                    $"\nPrice:{p.Price}\nQuantity:{p.QuantityInStock}");
                }
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option!!!!");
            break;
    }
    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);
*/

/*

public delegate void EDelegate();
public delegate void NDelegate(string name);
class Program
{

    public static void Main(string[] args)
    {
        HotelEvents hotelEvents = new HotelEvents();
        EDelegate del1 = hotelEvents.RegisterToEvent;
        del1.Invoke();
        NDelegate del2 = hotelEvents.EventNotification;
        del2.Invoke("music");

    }
}
*/


/*

class Program
{
    public delegate double Delegate1(EmployeeD employeeD);

    public static void Main(string[] args)
    {
        EmployeeD employee = new EmployeeD(199, "jack", 4);
        Delegate1 del = EmployeeD.BonusCalculation;

        Console.WriteLine("Employee Id: " + employee.EmployeeId +
            " Employee Name: " + employee.EmployeeName + " Performance Rating: " +
            employee.PerformanceRating + " Bonus: " + del.Invoke(employee));
    }
}
*/

/*

int ch, res;
List<TourismDestination> destinations = new List<TourismDestination>()
{
    new("Hyderabad","India",5),
    new("Kerala","India",4),
    new("Paris","France",5),
    new("Nandi Hills","India",5),
    new("Keerthi","BB",2)
};
//TourismDestination.tourismDestinations = destinations;
do
{
    Console.WriteLine("1-> Add Tourism Details\n2->View Destination list based on rating" +
       "\n3->exit");
    ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {
        case 1:
            Console.WriteLine("Enter the Name of destination");
            string? n = Console.ReadLine();
            Console.WriteLine("Enter the Name of Country");
            string? c = Console.ReadLine();
            Console.WriteLine("Rate your experience");
            int r = Convert.ToInt32(Console.ReadLine());
            if (r > 5 || r < 1)
            {
                Console.WriteLine("Please enter the rating between 1 to 5");
            }
            destinations.Add(new(n, c, r));
            break;
        case 2:
            Console.WriteLine("Ratings");
            TourismDestination.SortOnRating(destinations);
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option");
            break;


    }
    Console.WriteLine("Do you wish to continue\n1->yes\n2->no");
    res = Convert.ToInt32(Console.ReadLine());

} while (res == 1);

*/


/*

TouristDestination tourist = new TouristDestination();

List<TouristDestination> tours = new List<TouristDestination>()
 {
            new("Manali","Himachal Pradesh",5,2500),
            new("Kashmir","Jammu & Kashmir",4.5,4000),
            new("Paris","France",4.8,500000),
            new("Nandi Hills","Bangalore",4.2,1000),

        };

Console.WriteLine("Top-Rated");
tourist.TopRated(tours);
Console.WriteLine("List of Destination from low to high");
tourist.PriceAscending(tours);
Console.WriteLine("Enter the destination name");
string? resp = Console.ReadLine();
tourist.FilterDestination(resp, tours);
*/


/*

Hotel hotel = new Hotel("Hotel", availableRooms: 10);
async Task HotelBookingRequestAsync(string user,int numRoomsRequest)
{
    bool result = await hotel.BookRoomsAsync(numRoomsRequest);
    if (result)
    {
        Console.WriteLine($"{user} booked {numRoomsRequest} room(s).");
        

        
    }
    else
    {
        Console.WriteLine($"{user} couldn't book {numRoomsRequest} room(s) to insufficient availablity.");

    }
    Console.WriteLine($"Current room availability:{hotel.AvailableRooms}:{hotel.AvailableRooms}:{numRoomsRequest}");    
}
Task[] bookingTasks = new Task[]
{
HotelBookingRequestAsync("user1",3),
HotelBookingRequestAsync("user2",2),
HotelBookingRequestAsync("user3",5),
HotelBookingRequestAsync("user4",1),
};
await Task.WhenAll(bookingTasks);

*/

TourPackage tourPackage = new TourPackage();
List<TourPackage> packages = new List<TourPackage>()
{
    new(11,"Tirupati",new(2023,12,12),4500),
    new(22,"Mantralaya",new(2023,11,16),5500),
    new(18,"Shiradi",new(2024,1,12),7500),
};

Console.WriteLine("Enter the package id");
int p = Convert.ToInt32(Console.ReadLine());
bool IsBooked = false;
foreach (TourPackage package in packages)
{
    if (p == package.PackageId)
    {
        Thread thread = new Thread(() => package.TourBooking(package));
        thread.Start();
        thread.Join();
        IsBooked = true;

    }
}
if (!IsBooked)
{
    Console.WriteLine("Packed ID " + p + " doesn't exist");
}


