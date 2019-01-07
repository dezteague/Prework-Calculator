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

            //set up switch statement that uses variables as its parameters
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
        
        //addition method
        public static void Add(double firstNumber, string operation, double secondNumber)
        {
            double solution = firstNumber + secondNumber;
            Console.WriteLine(firstNumber + "+" + secondNumber + "=" + solution);
            Console.ReadLine();
        }

        //subtraction method
        public static void Subtract(double firstNumber, string operation, double secondNumber)
        {
            double solution = firstNumber - secondNumber;
            Console.WriteLine(firstNumber + "-" + secondNumber + "=" + solution);
            Console.ReadLine();
        }

        //multiplication method
        public static void Multiply(double firstNumber, string operation, double secondNumber)
        {
            double solution = firstNumber * secondNumber;
            Console.WriteLine(firstNumber + "*" + secondNumber + "=" + solution);
            Console.ReadLine();
        }

        //division method
        public static void Divide(double firstNumber, string operation, double secondNumber)
        {
            double solution = firstNumber / secondNumber;
            Console.WriteLine(firstNumber + "/" + secondNumber + "=" + solution);
            Console.ReadLine();
        }
    }
}

