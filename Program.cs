using System;
using System.IO;

namespace DemoConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputfile = Path.Combine(Environment.CurrentDirectory, "Names.txt");
           
            var Names = new StreamReader(inputfile);

            Console.SetIn(Names);

            string readvalue = Console.ReadLine();
            while(readvalue !=null)
            {
                Console.WriteLine("Value:-" + readvalue);
                readvalue = Console.ReadLine();
            }

            Console.WriteLine("Press Enter");
            //string s;
            //do
            //{
            //    s = Console.ReadLine();

            //    Console.WriteLine("Entered:-"+ s);

            //} while (s != null);
            //Console.WriteLine("What's your name ?");

            //var name =Console.ReadLine();

            //Console.WriteLine(name);

            //Console.ReadLine(); // FOR A PAUSE
        }
    }
}
