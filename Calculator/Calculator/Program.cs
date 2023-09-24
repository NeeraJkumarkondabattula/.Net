using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cal = true;
            while(cal)
            {
                Console.Write("Enter Number One : ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Number Two : ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Arthametic Operator : ");
                Console.WriteLine("\t + : ADD");
                Console.WriteLine("\t - : SUB");
                Console.WriteLine("\t * : MUL");
                Console.WriteLine("\t / : DIV");
                Console.WriteLine("\t % : MOD");
                String op = Console.ReadLine();
                //Console.WriteLine(op);

                switch (op)
                {
                    case "+":
                        Console.WriteLine("Addiction of " + num1 + " + " + num2 + " : " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("Subtraction of " + num1 + " - " + num2 + " : " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("Multiplication of " + num1 + " * " + num2 + " : " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine("Division of " + num1 + " / " + num2 + " : " + (num1 / num2));
                        break;
                    case "%":
                        Console.WriteLine("ModulerDivision of " + num1 + " % " + num2 + " : " + (num1 % num2));
                        break;
                }
                Console.Write("Would you like to Continue ? (Y/N) :");
                String res = Console.ReadLine();
                res = res.ToUpper();
                if(res == "N")
                {
                    cal = false;
                }
            }


            


            Console.ReadKey();
        }
    }
}
