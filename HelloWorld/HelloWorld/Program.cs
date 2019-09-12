using System;

namespace HelloWorld
{
    class Program
    { 
        public static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 + d2;

            float f1 = 3.5f;
            float f2 = 10.398f;
            float sumF = f1 + f2;

            Console.WriteLine(num1);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sumD);
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + sumF);
            Console.Read();

        }
        
    }
}
