using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginning_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie alt bist du?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 28)
            {
                Console.WriteLine("Viel Spaß!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Zeig mir mal deinen Ausweis");
            }
            else
            {
                Console.WriteLine("Du bist zu jung, Frischling");
            }

            Console.ReadLine();
        }
    }
}
