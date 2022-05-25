using System;

namespace learningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int num1 = 2;
            int sum = num + num1; 
            
            double d = 3.4;
            double dSum = num + d; 

            string name = "Farhan";

            Console.WriteLine(num + " + " + num1 + " = " + sum);
            Console.WriteLine(d + " + " + num1 + " = " + dSum);
            Console.WriteLine("Hello my name is " + name + "\n");
            //Console.WriteLine("Hello World!");
            Console.WriteLine("__GETTING DATA TYPE__"); 
            Console.WriteLine(dSum.GetType());
            Console.WriteLine(num.GetType());
            Console.WriteLine(name.GetType() + "\n"); 

            Console.WriteLine("___ DATA CASTING ___ ");
            Console.WriteLine("Double: " + d + " " + "Integer: " + (int)d );
            Console.WriteLine("Can also use Convert method --> " + Convert.ToInt32(d) + "\n");

            Console.WriteLine("__GETTING USER INPUT__");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Your username is: " + username + '\n');

            Console.WriteLine("__MATH__");
            double var = 6.59;
            int a = 8;
            int b = 5;
            double neg = -4.8; 
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.Round(var));
            Console.WriteLine(Math.Sqrt(var) + '\n');
            Console.WriteLine(""); 
            Console.WriteLine("__Strings__");
            string line = "The quick brown fox jumped over a lazy dog.";
            Console.WriteLine("The length of the string is: " + line.Length);
            Console.WriteLine(line.Substring(4, 6));
            Console.WriteLine(line.ToUpper());
            Console.WriteLine(line.ToLower());
            Console.WriteLine(line.ToCharArray().GetType());
            string firstName = "Farhan";
            string surname = "Hasan";
            Console.WriteLine($"My name is {firstName} {surname} + \n");

            Console.WriteLine("__IF ELSE STATEMENT__");
            int firstNum = 8;
            int secondNum = 9; 
            if(firstNum < secondNum)
            {
                Console.WriteLine($"{firstNum} is less than {secondNum}");
            }         
            else if(firstNum > secondNum)
            {
                Console.WriteLine($"{firstNum} is more than {secondNum}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }

            Console.WriteLine("");

            Console.WriteLine("__WHILE STATEMENT__");
            int i = 0; 
            while(i < 5)
            {
                Console.WriteLine(i);
                i++; 
            }
            Console.WriteLine("");

            Console.WriteLine("__FOR LOOPS__"); 
            for(int q = 0; q < 5; q++) { Console.WriteLine(q);  }
            Console.WriteLine("");

            Console.WriteLine("__FOREACH LOOP__");
            string[] cars = { "Volvo", "Jeep", "Volkswagen", "Audi", "Dodge" }; 
            foreach(string car in cars) { Console.WriteLine(car); }
            Console.WriteLine("");

            Console.WriteLine("__ARRAYS__");
            string[] names = {"Jim", "Tim", "Yim", "Pim", "Him?" };
            int[] rollNo = { 5, 4, 2, 3, 3, 4, 6, 4 };
            Console.WriteLine(names[0]);
            Console.WriteLine(rollNo[0]);
            foreach(int roll in rollNo) { Console.Write(roll + " "); }
            Console.WriteLine(""); 
            Array.Sort(rollNo);
            foreach(int roll in rollNo) { Console.Write(roll + " "); }
            Console.WriteLine("\n");

            Console.WriteLine("__FUNCTIONS / METHODS__"); 
            basicFunction();
            Console.WriteLine(addNums(5, 6));
            Console.WriteLine(addDoubleNums(5.43, 6.45) + "\r\n");

            Console.WriteLine("__OOP__");
            Car Ford = new Car("Ford", "Mustang", 1962, "Muscle");
            Console.WriteLine(Ford.company);
            Console.WriteLine(Ford.model);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Ford.type); 



        }

        static void basicFunction()
        {
            Console.WriteLine("I am a boring function. I can't do much."); 
        }
        
        static int addNums(int a, int b)
        {
            return a + b; 
        }

        static double addDoubleNums(double a, double b)
        {
            return a + b; 
        }
    }
}
