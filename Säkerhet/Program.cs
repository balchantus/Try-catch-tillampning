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
            //Användaren väljer säkerhet eller inte säkerhet
            Console.WriteLine("Skriv 'S' för säkerhet och 'N' för ingen säkerhet");
            string version = Console.ReadLine();
            
            //Dessa if-statements kollar om användaren vill använda säkerhet eller inte
            if (version == "S" || version == "s")
            {
                Med_säkerhet();
            }

            else if (version == "N" || version == "n")
            {
                Ingen_säkerhet();
            }
            
            else
            {
                Console.WriteLine("Fel, mata in S eller N");
            }
        }
    
        //Metod utan säkerhet som inte retunerar något eller behöver inparametrar
        static public void Ingen_säkerhet()
        {
            // Användar intergration
            Console.WriteLine("Enter two numbers you want to divide.");

            Console.Write("Enter numerator: ");
            //Converterar användarens inmatning (string) till en integer (int) för att kunna använda dem
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            //Converterar användarens inmatning (string) till en integer (int) för att kunna använda dem
            int b = int.Parse(Console.ReadLine());
            
            //Dividerar de två talen och skriver ut svaret
            int c = a / b;
            Console.WriteLine(c);
            
            //Detta gör bara så att konsolen är öppen tills en knapp trycks ned istället för att stängas direkt efter att svaret skrivits ut
            Console.ReadKey();
        }
        
        //Metod med däkerhet som inte retunerar något eller behöver inparametrar
        static public void Med_säkerhet()
        {
            //Användar intergration
            Console.WriteLine("Enter two numbers you want to divide.");
            
            //Try testar att köra koden och om det inte fungerar på grund av ett fel kommer catch fånga upp det
            try
            {
                //Användar intergration
                Console.Write("Enter numerator: ");
                //Som i metoden Ingen_säkerhet converteras användarens inmatning till en integer
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: ");
                //Converterar användarens inmatning till en integer
                int b = int.Parse(Console.ReadLine());
                
                //Dividerar talen och skriver ut det
                int c = a / b;
                Console.WriteLine(c);
            }
            
            //Här kommer alla fel att fångas upp
            //Det här catch statementet kollar om användaren försöker dividera med noll och om det är sant skriver ut att det inte går
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero. Please try again.");
            }
            
            //Här kollar det om användaren angivit ett tillåtet format, i det här fallet positiva/negativa heltal. Om användaren exempelvis skulle mata in '10,5' eller 'Hej' kommer det skriva ut att formatet är ogiltigt
            catch (FormatException)
            {
                Console.WriteLine("Not a valid format. Please try again.");
            }
            
            //Här fångas alla andra oväntade fel upp
            catch (Exception)
            {
                Console.WriteLine("Error occurred! Please try again.");
            }
            
            //Detta skrivs ut i slutet oavsett om ett fel inträffade eller inte och i detta fall uppmanar användaren att testa med andra tal
            finally
            {
                Console.WriteLine("Re-try with different numbers");
            }
        }
    }
}
