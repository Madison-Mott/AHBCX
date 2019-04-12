using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {




            //Exercise 1:
            Console.WriteLine("Hi User, say something!");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            do
            {

                //Exercise 2:
                Console.WriteLine("Hi User, enter a number!");
                string userInput2 = Console.ReadLine();
                int userNumber = int.Parse(userInput2);
                Console.WriteLine(userNumber + 1);

                //Exercise 3:
                Console.WriteLine("Hi User, enter ANOTHER number!");
                string userInput3 = Console.ReadLine();
                double userNum2 = double.Parse(userInput3);
                Console.WriteLine(userNum2 + .5);

                //Exercise 4:
                Console.WriteLine("Hi User, please enter two numbers now!");
                string userInput4 = Console.ReadLine();
                string userInput5 = Console.ReadLine();
                double userNum3 = double.Parse(userInput4);
                double userNum4 = double.Parse(userInput5);
                Console.WriteLine("The sum of the two numbers is " + (userNum3 + userNum4));

                //Exercise 5:
                Console.WriteLine("Hi User, please enter two more numbers now!");
                string userInput6 = Console.ReadLine();
                string userInput7 = Console.ReadLine();
                double userNum5 = double.Parse(userInput6);
                double userNum6 = double.Parse(userInput7);
                Console.WriteLine("The product of the two numbers is " + (userNum5 * userNum6));

                //Exercise 8:
                Console.WriteLine("Would you like to run throught this exercise again? Y or N");
                string userInput8 = Console.ReadLine();

                if (userInput8 == "N" || userInput8 == "n")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }


            } while (true);



            //Exercise 13


                Console.WriteLine("Hi User, please enter a number.");

                double userNum7 = double.Parse(Console.ReadLine());

                for (double i = userNum7; i > -1; i--)
                {
                    Console.WriteLine(i);
                }


                

                Console.ReadLine();
            
        }
    }
}
