using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryExample.Factory;

namespace FactoryExample
{
    public class Hero
    {
        private Movement _movement;
        private Weapon _weapon;

        public Hero(HeroFactory factory)
        {
            _movement = factory.CreateMovement();
            _weapon = factory.CreateWeapon();
        }

        public void Run()
        {
            _movement.Move();
        }

        public void Hit()
        {
            _weapon.Hit();
        }
    }
}
