using System;

/* Lines:
 *      36 --> uppercase lowercase 
 *      68 --> simple calculator
 *     160 --> console colors
 *     190 --> type casting variables
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * https://dofactory.com/csharp-coding-standards
 */
namespace learningcs
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*--------------------------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             * 
             * 
             * LOWER CASE
             * UPPER CASE
             * 
             * 
             * 
             * 
             * 
            --------------------------------------------------------------------------------------------------*/



            /*string Names = "amog he sus";
            string NewSentence = "sus " + Names;

            string LowerNewSentence = NewSentence.ToLower();
            string CapsNewSentence = NewSentence.ToUpper();

            Console.WriteLine(LowerNewSentence);
            Console.WriteLine(CapsNewSentence);

            Console.Read();
            */



            /*--------------------------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             * 
             * SIMPLE CALCULATOR
             * 
             * 
             * 
             * 
             * 
             * 
             * 
            --------------------------------------------------------------------------------------------------*/



            /*
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
            */

            /*
            int limit = 10;
            int num = Convert.ToInt32(Console.ReadLine());
            {
                if (num > limit)
                {
                    Console.WriteLine("Číslo je väčšie ako 10");
                }

                if (num < limit)
                {
                    Console.WriteLine("Číslo je menšie ako 10");
                }

                else
                {
                    Console.WriteLine("Číslo je 10");
                }
            }
            */



            /*--------------------------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             * 
             * 
             * CONSOLE COLOR
             * 
             * 
             * 
             * 
             * 
             * 
            --------------------------------------------------------------------------------------------------*/



            /*string x;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            x = Console.ReadLine();
            Console.WriteLine(x);

            Console.Read();
            */



            /*--------------------------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             * 
             * 
             * CASTING
             * 
             * 
             * Implicit - automatically (smol to larger)
             * ------------
             * char -> int -> long -> float -> double
             * 
             * 
             * Explicit - manually (larger to smol)
             * ------------
             * double -> float -> long -> int -> char
             * 
             * 
            --------------------------------------------------------------------------------------------------*/



            /*double myDouble = 3.14;
            int myInt;

            //cast double to int

            myInt = (int)myDouble;
            Console.WriteLine(myInt); //outputs 3
            Console.Read();


            Console.WriteLine(Convert.ToString(myInt));    //int to string
            Console.WriteLine(Convert.ToDouble(myInt));    //int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  //double to int
            Console.WriteLine(Convert.ToString(myBool));   //bool to string

            string myString = myDouble.ToString(); //outputs "3.14"
            */



            /*--------------------------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             * 
             * 
             *
             * 
             * 
             * 
             * 
             * 
             * 
            --------------------------------------------------------------------------------------------------*/




            /*
             * ASSIGMENT #1


                       string stringForFloat = "0.85"; // datatype should be float
                       string stringForInt = "12345"; // datatype should be int
                       int i = Int32.Parse(stringForInt);
                       float f = float.Parse(stringForFloat);
                       Console.WriteLine("int= " + i);
                       Console.WriteLine("float= " + f);
           */



            /*--------------------------------------------------------------------------------------------------
             * 
             * 
             * 
             * 
             * 
             * 
             *
             * 
             * 
             * 
             * 
             * 
             * 
            --------------------------------------------------------------------------------------------------*/
            string sus = "abcdef";
            Console.WriteLine(sus.Substring(1, 4));



        }
    }
}
