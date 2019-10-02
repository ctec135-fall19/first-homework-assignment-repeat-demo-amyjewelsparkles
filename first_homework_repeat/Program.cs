using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_homework_repeat
{
    class Program
    {
        static void Main(string[] args)
        {
            //customizing the console
            Console.Title = ("Hello World from Amina!");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n****** Hello World! ******\n\n");
            Console.BackgroundColor = ConsoleColor.Black;

            //insantiating the new car object

            SportsCar myCar = new SportsCar();
            
            //displaying the cars name

            Console.WriteLine("My car is: {0} \n\n", myCar.GetPetName());


        }
    }
}
