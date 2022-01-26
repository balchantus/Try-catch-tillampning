using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Säkerhet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv 'S' för säkerhet och 'N' för ingen säkerhet");
            string version = Console.ReadLine();

            if (version == "S" || version == "s")
            {
                Med_säkerhet();
            }

            if (version == "N" || version == "n")
            {
                Ingen_säkerhet();
            }
        }

        static public void Ingen_säkerhet()
        {
            Console.WriteLine("Enter two numbers. The first one is numerator and the second is denominator.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = a / b;
            Console.WriteLine(c);

            Console.ReadKey();
        }

        static public void Med_säkerhet()
        {
            while (true)
            {
                Console.WriteLine("Enter two numbers:");

                try
                {
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    int c = a / b;
                    Console.WriteLine(c);
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero. Please try again.");
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Invalid operation. Please try again.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid format. Please try again.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Error occurred! Please try again.");
                }

                finally
                {
                    Console.WriteLine("Re-try with different numbers");
                }
            }
        }
    }
}
