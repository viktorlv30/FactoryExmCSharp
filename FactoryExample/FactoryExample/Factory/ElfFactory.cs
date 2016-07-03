using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Factory
{
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMove();
        }

        public override Weapon CreateWeapon()
        {
            return new Pistol();
        }
    }
}
