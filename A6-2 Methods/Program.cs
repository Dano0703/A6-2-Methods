using System;

namespace A6_2_Methods
{
    class Temperature_Conversion
    {
        static void Main()
        {
            int f;

            double result;

            Console.WriteLine("Enter degrees in Fahrenheit: ");
             f = int.Parse(Console.ReadLine());
            result = (double)(5.0 / 9.0 * (f - 32));
            Console.WriteLine($"It is {result:0.##} degrees Celcius");
            Console.ReadLine();

            int c;

            double Result;

            Console.WriteLine("Enter degrees in celcius: ");
            c = int.Parse(Console.ReadLine());
            Result = (double)(9.0 / 5.0 * c + 32);
            Console.WriteLine($"It is {Result:0.##} degrees Fahrenheit");
            Console.ReadLine();



        } 
    }
}
