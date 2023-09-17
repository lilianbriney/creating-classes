using m2knowledge_check;
using System.Runtime.CompilerServices;



Console.WriteLine("How many records do you want to add? ");
var UserInput = Console.ReadLine();

    var numberOfRecords = int.Parse(Console.ReadLine());
    var recordList = new List<Car>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var Car = new Car();

    Console.WriteLine("Enter the value for ");
    Car.Int = Console.ReadLine();

    recordList.Add(Car);
    foreach (var record in recordList)
    { Console.WriteLine(Item.ToString());
    }
}

// Print out the list of records using Console.WriteLine()