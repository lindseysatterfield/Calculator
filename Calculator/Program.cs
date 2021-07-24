using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose to multiply (*), square (^), or add (+).");
            var operatorResponse = Console.ReadLine();

            Console.WriteLine("Enter three numbers separated by commas.");
            var userNumberInput = Console.ReadLine();

            switch (operatorResponse)
            {
                case "*":
                    var multiply = userNumberInput.Split(",");
                    Console.WriteLine(int.Parse(multiply[0]) * int.Parse(multiply[1]) * int.Parse(multiply[2]));
                    break;
                case "^":
                    var square = userNumberInput.Split(",");
                    Console.WriteLine(int.Parse(square[0]) * int.Parse(square[0]) + ", " + int.Parse(square[1]) * int.Parse(square[1]) + ", " + int.Parse(square[2]) * int.Parse(square[2]));
                    break;
                case "+":
                    var add = userNumberInput.Split(",");
                    Console.WriteLine(int.Parse(add[0]) + int.Parse(add[1]) + int.Parse(add[2]));
                    break;
                default:
                    break;
            }
            
        }
    }
}
