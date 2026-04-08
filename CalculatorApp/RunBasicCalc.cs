using System;

namespace Basic
{
    public static class MainBasicCal
    {
            public static void RunBasicCal()
        {
            BasicCal bc = new BasicCal();

            double a, b;
            char ops;
            char[] ValidOps = {'+', '-', '*', '/', '%'};

            Console.Write("Enter first number: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Enter a valid input!");
                Console.WriteLine("Enter first number: ");
            }

            while(true)
            {
                Console.Write("Enter operator { + - * / % }: ");
                ops = Console.ReadKey().KeyChar;
                Console.WriteLine("");

                if(!ValidOps.Contains(ops))
                {
                    Console.WriteLine("Invalid operator!");
                    continue;
                }
                break;
            }

            while(true)
            {
                Console.WriteLine("Enter second number: ");
            
                if(!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Enter a valid input!");
                    continue;
                }

                if((ops == '/' || ops == '%') && b == 0)
                {
                    Console.WriteLine("You cannot use zero");
                    continue;
                }
                break;


            }

            switch(ops)
            {
                case '+':
                Console.WriteLine(bc.Add(a, b));
                break;

                case '-':
                Console.WriteLine(bc.Sub(a, b));
                break;

                case '*':
                Console.WriteLine(bc.Mul(a, b));
                break;

                case '/':
                Console.WriteLine(bc.Div(a, b));
                break;

                case '%':
                Console.WriteLine(bc.Mod(a, b));
                break;

                default:
                Console.WriteLine("Enter a valid operator");
                break;
            }

        }
      }
}

