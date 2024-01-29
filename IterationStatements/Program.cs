﻿namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintByThree()
        {
            for (int i = 3 ; i <= 999; i+=3 )
            {
                Console.WriteLine(i);
            }
        }

    //Write a method to accept two integers as parameters and check whether they are equal or not
    public static void IsEqual(int num1, int numb2)
        {
            if (num1 == numb2)
            {
                Console.WriteLine($"{num1} is equal to {numb2}");
            }
            else
            {
                Console.WriteLine($"{num1} is not equal to {numb2}");
            }
        }
        

        //Write a method to check whether a given number is even or odd

        public static void EvenOrOdd(int number)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg(int number)
        {
            if (number >= 0)
            {
                Console.WriteLine($"{number} is positive");
            }
            else
            {
                Console.WriteLine($"{number} is negative");
            }
        }
        

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void CanPersonVote()
        {
            Console.WriteLine("Please put your age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Your are eligible to vote");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible to vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void IsNumberInRage()
        {
            Console.WriteLine("Please enter in a number");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine("Number is in Range");
            }
            else
            {
                Console.WriteLine("Number is NOT in range");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable(int num)
        {
            for(int i = 1; i >= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i*num}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNumbers();
            //PrintByThree();
            //IsEqual(5,5);
            //EvenOrOdd(8);
            //PosOrNeg(-3);
            //CanPersonVote();
            //IsNumberInRage();
            MultiplicationTable(5);



        }
    }
}
