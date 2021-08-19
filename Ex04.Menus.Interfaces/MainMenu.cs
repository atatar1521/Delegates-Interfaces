using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private SubMenu m_MainMenu;

        public MainMenu()
        {
            m_MainMenu = new SubMenu();
        }

        public SubMenu MainMenuItems
        {
            get { return m_MainMenu; }
        }

        public void Add(MenuItem i_MenuItem)
        {
            MainMenuItems.Add(i_MenuItem);
            MainMenuItems.MenuItemList[0].Title = "Exit";
        }

        public void Show()
        {
            MainMenuItems.DoWhenSelected();
        }
    }
}
