using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Pistol : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем пистолетом!");
        }
    }
}
