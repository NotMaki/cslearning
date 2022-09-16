using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ans;
            Console.WriteLine("1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Operator:");
            Console.WriteLine("+ - ÷ / x ×");
            string znamienko = Console.ReadLine();

            switch (znamienko)
            {
                case "+":
                    ans = num1 + num2;
                    break;

                case "-":
                    ans = num1 - num2;
                    break;

                case "x":
                    ans = num1 * num2;
                    break;

                case "*":
                    ans = num1 * num2;
                    break;

                case "×":
                    ans = num1 * num2;
                    break;

                case "/":
                    ans = num1 / num2;
                    break;

                case "÷":
                    ans = num1 / num2;
                    break;

                default:
                    ans = 30307;
                    break;
            }
            Console.WriteLine("▄-▄████▄-▄-▄████▄-▄-▄████▄-▄-▄████▄-▄-▄████▄-▄-▄████▄");
            Console.WriteLine("  ");
            Console.WriteLine(num1.ToString() + " " + znamienko + " " + num2.ToString() + " = " + ans.ToString());
            Console.WriteLine("  ");
            Console.WriteLine("▄-▄████▄-▄-▄████▄-▄-▄████▄-▄-▄████▄-▄-▄████▄-▄-▄████▄");
        }
    }
}

