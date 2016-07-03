using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Factory
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new JumpMove();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
