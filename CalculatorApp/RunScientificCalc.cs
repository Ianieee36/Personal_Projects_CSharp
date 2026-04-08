using System;

namespace Scientific
{
    public static class MainScientificCal 
    {
        private static double ReadDouble(string prompt)
        {
            double value;

            while(true)
            {
                Console.WriteLine(prompt);

                string? input = Console.ReadLine();

                if(double.TryParse(input, out value))
                    return value;

                    Console.WriteLine("Invalid Number! Try again!");
            }
        }
        public static void RunScientificCal()
        {   

            SciCal sc = new SciCal();
            

            
        while (true)
            {
                Console.WriteLine("Scientific Operations");
                Console.WriteLine("1. Power");
                Console.WriteLine("2. SquareRoot");
                Console.WriteLine("3. Sine");
                Console.WriteLine("4. Cosine");
                Console.Write("Choose Operation: ");

                String? choice = Console.ReadLine();

            
                if(choice == "1")
            {
                double a = ReadDouble("Enter Base: "); 
                double b = ReadDouble("Enter Exponent: "); 
            
                Console.WriteLine(sc.Power(a, b));
                
            } else if(choice == "2")
            {
                double a = ReadDouble("Enter a principal root: ");
                Console.WriteLine(sc.SquareRoot(a));

            } else if(choice == "3")
            {
                double a = ReadDouble("Enter an angle: ");
                Console.WriteLine(sc.Sin(a));

            } else if (choice == "4")
            {
                double a = ReadDouble("Enter an angle: ");
                Console.WriteLine(sc.Cos(a));

            } else
            {
                Console.WriteLine("Invalid scientific operation");
            }   

            }

            
        }   
    }
}