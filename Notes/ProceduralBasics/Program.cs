using System;

namespace ProceduralBasics
{
    // in a console application project (which is athe template that we made with the "dotnet new")
    // the runtime looks for a static method named main
    { 
    class Program
        static void Main(string[] args)
        {
            Console.Write("Enter a Number");
            int v = Convert.ToInt32(Console.ReadLine());
            // print out triange of some size
            Console.WriteLine("Your number is " + v);

            
        }
    }
}
