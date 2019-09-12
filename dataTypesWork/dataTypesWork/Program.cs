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

            //classes use pascal case: NewClassName
            //method names use pascal case
            //method arguments use camel case: firstNumber
            //local variables use camel case
            //don't use abbreviations: userControl not usrCtr
            //dont use numbers at the start of variable names: int cars3 not int 3cars
            //underscores only at the beginning of variable names: _loginDate not login_Date
            //use lowercase for datatypes: string not String, int not Int, bool not Boolean
            //classes use nouns or noun phrases: Program, Employee, BusinessDate
            //methods are actions so use verbs and verb phrases
            //www.dofactory.com/reference/csharp-coding-standards for more information


        }
    }
}
