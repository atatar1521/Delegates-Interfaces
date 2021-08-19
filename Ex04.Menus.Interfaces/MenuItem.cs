using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private string m_Title = string.Empty;
        private int m_MenuItemIndex = 0;

        internal abstract void DoWhenSelected();

        public int MenuItemIndex
        {
            get { return m_MenuItemIndex; }
            set { m_MenuItemIndex = value; }
        }

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
    }
}
