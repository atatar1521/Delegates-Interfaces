using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfaceShowVersion : ISelectInterface
    {
        public void Excute()
        {
            Console.WriteLine("Version: 21.1.4.8930");
        }
    }
}
