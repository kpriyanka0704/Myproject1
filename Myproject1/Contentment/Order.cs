using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myproject1.Contentment
{

    class Menu
    {
        public int eid;
        public string eitem;
        public float eprice;
        public string emenu;

        public Menu(int eid, string eitem, float eprice)
        {
            this.eid = eid;
            this.eitem = eitem;
            this.eprice = eprice;
        }
        public void DisplayMenu()
        {
            Console.WriteLine(eid+" "+eitem+" "+eprice);
        }

        
    }
    internal class Order
    {
        int id;
        float qty;
        Menu emenu;

        Order(int id, float qty, Menu emenu)
        {
            this.id = id;
            this.qty = qty;
            this.emenu = emenu;
        }
        public void ShowOrder()
        {
            Console.WriteLine(id+" "+qty);
            emenu.DisplayMenu();
        }
    }


}
