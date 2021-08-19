using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateShowTime 
    {
        public void Excute()
        {
            string time = DateTime.Now.ToLongTimeString();
            Console.WriteLine(time);
        }
    }
}
