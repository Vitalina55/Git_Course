using System;

namespace project_Vitalina
{
    class MainClass

    {
        static int factorialNumber(int num)
        {

            return num == 0 ? 1 : factorialNumber(num - 1) * num;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int result = factorialNumber(num);
            Console.WriteLine($"Factorial of a number {num}! = " + result);
        }
    }
}