using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2
{
    public partial class ProductsList
    {
        private static readonly List<Product> Products = new ()
        {
            new (101, "Tomato", 12),
            new (102, "Pineapple", 45),
            new (103, "Carrot", 5),
            new (104, "Pepsi", 7),
            new (105, "Snickers", 5),
            new (106, "Juice", 20),
            new (107, "Bread", 8),
            new (108, "Fanta", 8),
            new (109, "7up", 7),
            new (110, "Marlboro", 25),
            new (111, "Beer", 10),
            new (112, "Aspirine", 7),
            new (113, "IceCream", 4),
            new (114, "JackDaniels", 99),
            new (115, "Heets", 27),
            new (116, "Meat", 30),
            new (117, "Butter", 15),
            new (118, "Sauce", 12),
        };
    }
}
