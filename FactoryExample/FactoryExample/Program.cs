using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword sw = new Sword();
            Pistol ps = new Pistol();
            FlyMove fly = new FlyMove();
            JumpMove jp = new JumpMove();

            sw.Hit();
            ps.Hit();
            fly.Move();
            jp.Move();

            Console.ReadKey();

        }
    }
}
