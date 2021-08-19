using System;

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;

    public static class DelegateMenu
    {
        public static void RunDelegateMenu()
        {
            MainMenu mainMenu = createDelegateMenu();
            mainMenu.Show();
        }

        private static MainMenu createDelegateMenu()
        {
            MainMenu delegateMainMenu = new MainMenu();
            delegateMainMenu.MainMenuItems.Title = " Delegates Main Menu";
            SubMenu versionAndSpaces = new SubMenu("Version and Spaces");
            DelegateCountSpaces countSpaces = new DelegateCountSpaces();
            AddItem addCountSpacesItem = new AddItem("Count Spaces", countSpaces.Excute);
            versionAndSpaces.Add(addCountSpacesItem);
            DelegateShowVersion showVersion =  new DelegateShowVersion();
            AddItem addShowVersionItem = new AddItem("Show Version", showVersion.Excute);
            versionAndSpaces.Add(addShowVersionItem);
            delegateMainMenu.Add(versionAndSpaces);
            SubMenu dateAndTime = new SubMenu("Show Date/Time");
            DelegateShowDate showDate = new DelegateShowDate();
            AddItem addDateItem = new AddItem("Show Date", showDate.Excute);
            dateAndTime.Add(addDateItem);
            DelegateShowTime showTime = new DelegateShowTime();
            AddItem addTimeItem = new AddItem("Show Time", showTime.Excute);
            dateAndTime.Add(addTimeItem);
            delegateMainMenu.Add(dateAndTime);
            return delegateMainMenu;
        }
    }
}
