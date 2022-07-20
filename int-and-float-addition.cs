using System;

namespace _2._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            //assigning a value to a variable
            num1 = 13;

            //declaring an initializing a value in one go
            int num2 = 23;

           

            num2 = 100;

            int sum = num1 + num2;
            //using concatination

            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            //declaring multiple variables at once
            int num3, num4, num5;

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2; //the result of d1/d2 will be stored under the name "dDiv"
            Console.WriteLine("d1 / d2 is " + dDiv);

            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);


            double dIDiv = d1 / num1;
            Console.WriteLine("f1/f2 is " + fDiv);

            Console.Read();
        }
    }
}
