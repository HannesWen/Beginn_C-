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
            string entry = "Das ist ein Text mit Wörtern";
            //0: Das
            //1: ist
            //2: ein
            //3: Text
            //4: mit
            //5: Wörtern
                        
            string[] entries = entry.Split(' ');
            foreach(string wort in entries)
            {
                Console.WriteLine(wort);
            }
            
            for(int i=0; i< entries.Length; i++)
            {
                Console.WriteLine(entries[i]);
            }

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i < 10);


            //int i = 0;
            //while(i <10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for (int i = 0;i< 10; i++)

            Console.ReadLine();
        }





    }
}
