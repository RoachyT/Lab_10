using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            //call circle class, get numbers and display it 
            //writelines will be called here 
            calculate();

        }
        static void calculate()
        {
           
            Console.Write("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius);
            Console.WriteLine($"The circumference is {circle.CalculateFormattedCircumference()}");
            Console.WriteLine($"The area is {circle.CalculateFormattedArea()}");
            count++;
        
            looping();
        }

        static void looping()
        {
            Console.WriteLine("Would you like to calculate another circle? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {
                Console.Clear();
                calculate();

            }
            else if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine($"Goodbye, you made {count} circles");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
        }
    }
}

        

