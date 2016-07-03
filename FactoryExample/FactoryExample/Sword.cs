using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Удар мечем!");
        }
    }
}
