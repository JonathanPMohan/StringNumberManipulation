using System;

namespace StringNumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Comma Seperated Number String.");
            var userInput = Console.ReadLine().Split(',');
            Console.WriteLine("Type: multiply or square Depending On Your Preference?");
            var multiply = Console.ReadLine();
            int product = 1;
            var solution = "";
            for (int i = 0; i < userInput.Length; i++)
            {
                if (multiply == "multiply")
                {
                    product = product * Convert.ToInt32(userInput[i]);
                    solution = product.ToString();
                }
                if (multiply == "square")
                {
                    product = Convert.ToInt32(userInput[i]) * Convert.ToInt32(userInput[i]);

                    if (i != userInput.Length - 1)
                    {
                        solution += product.ToString() + ", ";
                    }
                    else
                    {
                        solution += product.ToString();
                    }
                }
            }
            Console.Write("Your Solution Is: " + solution);
            Console.ReadKey();
        }
    }
}