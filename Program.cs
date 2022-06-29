using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalga2Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Višina visina = new Višina();

            visina.Dodaj(4532);
            Console.WriteLine(visina.ToString());

        }
    }
}
