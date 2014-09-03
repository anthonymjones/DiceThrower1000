using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //call the ThrowDice function
            ThrowDice("10d6");
            
            
            //keep window open
            Console.ReadKey();
        }

        //create a function called ThrowDice that takes the string parameter "diceString" and prints the results of the dice throws
        static void ThrowDice(string diceString)
        {
            //create a string to hold our results
            string results =String.Empty;

            //splits the string betweens rolls and sides
            string[] input = diceString.Split('d');

            //create a variable to hold number of rolls
            int rolls = int.Parse(input[0]);
            //create a variable to hold number of sides
            int sides = int.Parse(input.Last());
            //create random number generator to generate which side is rolled
            Random randomNumberGenerator = new Random();
 
            //create a for loop to run through the number of rolls
            for (int i = 1; i <= rolls; i++)
            {
                
                int randomNumber = randomNumberGenerator.Next(1, sides + 1);
                
                //add the random number generated to the results output
                results = results + randomNumber + " ";

            }
            //Print Throwing and Results
            Console.WriteLine("Throwing: " + diceString);
            Console.WriteLine("Results: " + results);

        }

    }
}
