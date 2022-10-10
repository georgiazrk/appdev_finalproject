using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Sheep: Animal
    {
        public double amtOfWool;
        public Sheep(int id, double amtOfWool) : base(id)
        {
            this.amtOfWool = amtOfWool;
        }
    }
}
