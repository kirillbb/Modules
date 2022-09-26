using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public static class Basket
    {
        private static List<Product> basketList = new ();
        internal static List<Product> BasketList { get => basketList; set => basketList = value; }
    }
}
