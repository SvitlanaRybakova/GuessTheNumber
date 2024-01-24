using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int minValue, maxValue;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            minValue = rand.Next(number - 10, number);
            maxValue = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Try to determine the number. It surpasses {minValue} but lower than {maxValue}");
            Console.WriteLine($"What is the number? You have {triesCount} attempts");

            while (triesCount-- > 0)
            {
                Console.WriteLine("Type your answer: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if(userInput == number)
                {
                    Console.WriteLine( $"Congrats! This is a right number. The number was {number}.");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, this number is incorrect. Try more");
                }
            }
        }
    }
}
