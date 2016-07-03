using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryExample.Factory;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Console.ReadKey();

        }
    }
}
