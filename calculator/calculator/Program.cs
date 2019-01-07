using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //"double" variable type allows up to 16 digits

            //prompt user for first number
            Console.WriteLine("Enter your first number: ");
            string a = Console.ReadLine();
            //convert first string into an integer
            double firstNumber = Convert.ToInt32(a);

            //prompt user for second number
            Console.WriteLine("Enter your second number: ");
            string b = Console.ReadLine();
            //convert second string into integer
            double secondNumber = Convert.ToInt32(b);

            //prompt user to select an operation
            Console.WriteLine("Select your mathematic operator (+, -, *, /)");
            string operation = Console.ReadLine();

            //set up switch statement
            switch (operation)
            {
                case "+":
                    Add(firstNumber, operation, secondNumber);
                    break;
                case "-":
                    Subtract(firstNumber, operation, secondNumber);
                    break;
                case "*":
                    Multiply(firstNumber, operation, secondNumber);
                    break;
                case "/":
                    Divide(firstNumber, operation, secondNumber);
                    break;
            }
        }

    }
}

