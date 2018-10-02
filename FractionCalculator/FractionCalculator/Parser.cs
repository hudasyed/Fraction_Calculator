using FractionCalculator.Numbers;
using FractionCalculator.Operators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FractionCalculator
{
    public static class Parser
    {
        public static void Parse(string input)
        {
            try
            {
                string[] tokens = input.Split(" ");
                VerifyInput(tokens);
                RunCalculation(tokens);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void RunCalculation(string[] tokens)
        {
            INumber first = GetNumber(tokens[0]);
            INumber second = GetNumber(tokens[2]);
            string response = "";
            switch (tokens[1])
            {
                case "+":
                    response = Add.Calculate(first, second).GetValue();
                    break;
                case "-":
                    response = Subtract.Calculate(first, second).GetValue();
                    break;
                case "*":
                    if (first.GetValue() == "0" || second.GetValue() == "0") response = "0";
                    else response = Multiply.Calculate(first, second).GetValue();
                    break;
                case "/":
                    if (first.GetValue() == "0") response = "0";
                    else if (second.GetValue() == "0") throw new DivideByZeroException("You cannot divide a number by zero.");
                    else response = Divide.Calculate(first, second).GetValue();
                    break;
                default:
                    break;
            }
            Console.WriteLine(response);
        }

        private static void VerifyInput(string[] input)
        {
            Exception ex = new FormatException("The content of this calculation was not formatted correctly.");
            List<string> operators = new List<string> { "+", "-", "/", "*" };
            if (input.Length != 3 || !operators.Contains(input[1])) throw ex;

            try
            {
                VerifyNumber(input[0]);
                VerifyNumber(input[2]);
            }
            catch(Exception)
            {
                throw ex;
            }
            
        }

        private static void VerifyNumber(string number)
        {
            string[] numbers;
            if (!Int32.TryParse(number, out int whole))
            {
                if(number.Contains('_'))
                {
                    numbers = number.Split("_");
                    if(!Int32.TryParse(numbers[0], out int mixed))
                    {
                        throw new Exception();
                    }
                    if(mixed == 0)
                    {
                        throw new Exception();
                    }
                    number = numbers[1];
                }
                numbers = number.Split("/");
                if(!Int32.TryParse(numbers[0], out int numerator) || !Int32.TryParse(numbers[1], out int denominator))
                {
                    throw new Exception();
                }
                if(numerator == 0 || denominator == 0)
                {
                    throw new Exception();
                }
            }
        }

        public static INumber GetNumber(string number)
        {
            int whole;

            string[] numbers;
            if (!Int32.TryParse(number, out whole))
            {
                int complex = 0;
                int numerator;
                int denominator;
                if (number.Contains('_'))
                {
                    numbers = number.Split("_");
                    complex = Int32.Parse(numbers[0]);
                    number = numbers[1];
                }
                numbers = number.Split("/");
                numerator = Int32.Parse(numbers[0]);
                denominator = Int32.Parse(numbers[1]);
                return MathHelper.ReduceFraction(new Fraction(complex + numerator, denominator));
            }
            else
            {
                return new Whole(whole);
            }
        }
    }
}