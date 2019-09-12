using System;

namespace dataTypesWork
{
    class MainClass
    {
        //constants as fields
        const double PI = 3.1415926539;
        const int weeks = 52, months = 12;
        const string birthday = "02AUG1983";

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
            Console.WriteLine("The sum of " + f1 + " and " + f2 + " is " + sumF + "\n");

            //---------------------------------------------

            string myName = "Jason";
            string message = "My name is " + myName + "!";

            string capsMessage = message.ToUpper();
            string lowMessage = capsMessage.ToLower();

            Console.WriteLine(myName);
            Console.WriteLine("My name is " + myName);
            Console.WriteLine(message);
            Console.WriteLine(capsMessage);
            Console.WriteLine(lowMessage + "\n");

            //-------------------------------------------------

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

            //------------------------------------------------

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
            Console.WriteLine(myBoolString + "\n");

            //-----------------------------------

            string myNewString = "15";
            string mySecondString = "13";
            int numFromString = Int32.Parse(myNewString);
            int numFromString2 = Int32.Parse(mySecondString);

            string result = myNewString + mySecondString;
            int resultInt = numFromString + numFromString2;

            Console.WriteLine(result);
            Console.WriteLine(resultInt + "\n");

            //------------------------------------

            byte myByte = 1;
            Console.WriteLine(myByte);
            sbyte mySbyte = 12;
            Console.WriteLine(mySbyte);
            int myIntTest = 12453;
            Console.WriteLine(myIntTest);
            uint myUint = 123452;
            Console.WriteLine(myUint);
            short myShort = 23987;
            Console.WriteLine(myShort);
            ushort myUshort = 65000;
            Console.WriteLine(myUshort);
            long myLongTest = 243958889;
            Console.WriteLine(myLongTest);
            ulong myUlong = 592349857;
            Console.WriteLine(myUlong);
            float myFloatTest = 345.234f;
            Console.WriteLine(myFloatTest);
            double myDoubleTest = 56234.65433;
            Console.WriteLine(myDoubleTest);
            char myChar = 'A';
            Console.WriteLine(myChar);
            bool myBool = false;
            Console.WriteLine(myBool);
            decimal myDecimal = 342.2345675434566m;
            Console.WriteLine(myDecimal);
            string myStringTest = "I control text";
            Console.WriteLine(myStringTest);
            string myNumStringTest = "213";
            int myNumStringTestInt = Int32.Parse(myNumStringTest);
            Console.WriteLine(myNumStringTestInt + "\n");

            //---------------------------------------

            //constants are immutable values which are known at the compile time
            //and do not change for the life of the program

            //constants are declared at the top of the program prior to the main

            Console.WriteLine("My birthday is always going to be: {0}", birthday);

            //---------------------------------------
        }
    }
}
