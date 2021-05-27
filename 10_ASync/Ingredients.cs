using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ASync
{
    public class Potato
    {
        public Potato()
        {
            IsPeeled = false;
        }

        public Potato(bool isPeeled)
        {
            isPeeled = isPeeled;
        }

        public bool IsPeeled { get; set; }

        public bool Peel()
        {
            Console.WriteLine("You start peeling the potato");
            Task.Delay(2000).Wait();
            IsPeeled = true;
            Console.WriteLine("You peeled the potato");
            return true;
        }
    }

    public class Fries
    {
        public Fries(Potato potato) { }
    }

    public class Hamburger { }

}
