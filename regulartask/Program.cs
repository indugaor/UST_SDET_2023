// See https://aka.ms/new-console-template for more information
using regular;
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