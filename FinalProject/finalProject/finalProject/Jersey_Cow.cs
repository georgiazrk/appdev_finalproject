using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Jersey_Cow: Cow
    {
        public Jersey_Cow(int id, double amtOfMilk) : base(id, amtOfMilk)
        {
            this.amtOfMilk = amtOfMilk;
        }
    }
}
