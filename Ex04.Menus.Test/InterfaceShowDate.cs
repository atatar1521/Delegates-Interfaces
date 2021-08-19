using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    class InterfaceShowDate : ISelectInterface
    {
        public void Excute()
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
        }
    }
}
