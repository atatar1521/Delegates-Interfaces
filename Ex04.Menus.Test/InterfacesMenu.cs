using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public static class InterfacesMenu
    {
        public static void RunInterfacesMenu()
        {
            MainMenu mainMenu = createInterfacesMenu();
            mainMenu.Show();
        }

        private static MainMenu createInterfacesMenu()
        {
            MainMenu interfaceMainMenu = new MainMenu();
            interfaceMainMenu.MainMenuItems.Title = " Interfaces Main Menu";
            SubMenu versionAndSpaces = new SubMenu("Version and Spaces");
            InterfaceCountSpaces countSpaces = new InterfaceCountSpaces();
            AddItem addCountSpacesItem = new AddItem("Count Spaces", countSpaces);
            versionAndSpaces.Add(addCountSpacesItem);
            InterfaceShowVersion showVersion = new InterfaceShowVersion();
            AddItem ShowVersionItem = new AddItem("Show Version", showVersion);
            versionAndSpaces.Add(ShowVersionItem);
            interfaceMainMenu.Add(versionAndSpaces);
            SubMenu dateAndTime = new SubMenu("Show Date/Time");
            InterfaceShowDate showDate = new InterfaceShowDate();
            AddItem addDateItem = new AddItem("Show Date", showDate);
            dateAndTime.Add(addDateItem);
            InterfaceShowTime showTime = new InterfaceShowTime();
            AddItem addTimeItem = new AddItem("Show Time", showTime);
            dateAndTime.Add(addTimeItem);
            interfaceMainMenu.Add(dateAndTime);
            return interfaceMainMenu;
        }
    }
}
