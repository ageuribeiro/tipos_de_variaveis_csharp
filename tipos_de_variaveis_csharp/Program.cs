using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tipos_de_variaveis_chsarp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Tipagem dinâmica
            var x = 1;
            //x = "sss";

            // Tipagem estática
            int y = 2;
            //y = "s";

            string s = "Ageu";

            var s2 = s;

            var f = 1.5f;
            float f2 = 1.5f;

            var d = 1.5;
            double d2 = 1.5;

            var bool1 = true;
             
            bool bool2 = false;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(s2);
            Console.WriteLine(f);
            Console.WriteLine(f2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(bool1);
            Console.WriteLine(bool2);
        }
    }
}