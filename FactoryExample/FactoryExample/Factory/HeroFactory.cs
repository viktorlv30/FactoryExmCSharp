using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Factory
{
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();

    }
}
