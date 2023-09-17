using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace m2knowledge_check
{
    internal class Vehicle : Car
    {
      public string Make { get; set; }
      public string Model { get; set; }
      public int Year { get; set; }

    public Vehicle (string make, string model, int year)
        {
            Make = make;    
            Model = model;
            Year = year;
        }
        public void SetPropertiesFromUserInput()
        {
            Console.WriteLine("Enter vehicle make: ");
             string Make = Console.ReadLine();

            Console.WriteLine("Enter vehicle model: ");
            string Model = Console.ReadLine();

            Console.WriteLine("Enter vehicle year: ");
            string UserInput = Console.ReadLine();

            int year;
            if(int.TryParse(UserInput, out year))
            {
                Console.WriteLine($"Entered valid year; {year}");
            }
            else
            {
                Console.WriteLine("Invalid input please enter year as nummber")
            }

            Console.ReadLine();
              public override string ToString()
        {
                 return $"car: {Make},Model: {Model},Year: {Year}";
        }
    }
}
