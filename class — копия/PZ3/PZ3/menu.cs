using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ3
{
    

        class menu
        {
            private int price;
            private string name;
            public int gramm;

            public menu(string name, int price, int gramm)
            {

                this.name = name;
                this.price = price;
                this.gramm = gramm;

            }
        }
    
}
