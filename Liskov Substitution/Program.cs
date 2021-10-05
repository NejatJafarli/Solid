using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution
{
    interface IShotable
    {
        void Shot();
    }
    interface IMoveable
    {
        void Move();
    }

    class TigerTank : IShotable, IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Tiger Tank Moved");
        }

        public void Shot()
        {
            Console.WriteLine("Tiger Tank Shoted");
        }
    }

    class KirpiPersonnelCarrierVehicle : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("Kirpi Vehicle Moved");
        }
    }
    class Cannon : IShotable
    {
        public void Shot()
        {
            Console.WriteLine("Cannon Shoted");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Liskov Prinsipi Eyni Base classdan toreyen
            //Classlar Birbirlerinin deyine Hecbir deyisiklik olmadan kece bilmelidir

        }
    }
}
