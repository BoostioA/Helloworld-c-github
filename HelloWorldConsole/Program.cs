using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Wat is uw naam");



            string naam = Console.ReadLine();

            if (naam == "aaron")
            {
                

                Console.Write("ja dat klopt " + naam);

                Console.Write(Environment.NewLine);

                Console.WriteLine("Wat is uw huisdier");

                string huisdier = Console.ReadLine();
                
                if (huisdier == "yoshi") 

                    Console.Write("ja dat klopt " + naam );

            }


            Console.ReadLine();
        }
    }
}
