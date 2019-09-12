using System;

namespace dataTypesWork
{
    class MainClass
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



            string myName = "Jason";
            string message = "My name is " + myName + "!";

            string capsMessage = message.ToUpper();
            string lowMessage = capsMessage.ToLower();

            Console.WriteLine(myName);
            Console.WriteLine("My name is " + myName);
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowMessage);

        }
    }
}
