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


            //implicit conversion: can go from less to greater precision but not the other way
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            //explicit conversion
            double myDouble = 13.37;
            int myInt;
            //cast double to int
            myInt = (int)myDouble;

            Console.WriteLine(myInt);

            //type conversion
            string myString = myDouble.ToString();
            string myIntString = num.ToString();
            string myLongString = bigNum.ToString();
            string myFloatString = myFloat.ToString();

            bool sunIsShining = false;
            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myFloatString);
            Console.WriteLine(myBoolString);


            string myNewString = "15";
            string mySecondString = "13";
            int numFromString = Int32.Parse(myNewString);
            int numFromString2 = Int32.Parse(mySecondString);

            string result = myNewString + mySecondString;
            int resultInt = numFromString + numFromString2;

            Console.WriteLine(result);
            Console.WriteLine(resultInt);
        }
    }
}
