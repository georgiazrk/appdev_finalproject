using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Cow: Animal
    {
        public double amtOfMilk;
        public Cow(int id, double amtOfMilk) : base(id)
        {
            this.amtOfMilk = amtOfMilk;
        }
    }
}
