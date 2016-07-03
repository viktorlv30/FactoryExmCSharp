using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class JumpMove : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Здесь прыгаем!");
        }
    }
}
