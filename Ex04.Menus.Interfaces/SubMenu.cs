using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItemList;

        public SubMenu(string i_Title)
        {
            r_MenuItemList = new List<MenuItem>();
            Title = i_Title;
        }

        public SubMenu()
        {
            r_MenuItemList = new List<MenuItem>();
        }

        public List<MenuItem> MenuItemList
        {
            get { return r_MenuItemList; }
        }

        public void Add(MenuItem i_MenuSubItemToAdd)
        {
            if (MenuItemList.Count == 0)
            {
                MenuItem backItem = new AddItem
                {
                    Title = "Back",
                    MenuItemIndex = 0,
                };

                MenuItemList.Add(backItem);
            }

            i_MenuSubItemToAdd.MenuItemIndex = MenuItemList.Count;
            MenuItemList.Add(i_MenuSubItemToAdd);
        }

        internal override void DoWhenSelected()
        {
                showSubMenu();
        }

        private void showSubMenu()
        {
            int userChoice;
            Console.WriteLine(
                    "=========================" +
                    Environment.NewLine +
                    Title +
                    Environment.NewLine +
                    "=========================");
            printItemList();
            Console.WriteLine("=========================");
            userChoice = getUserChoice();
            Console.Clear();
            if (userChoice != 0)
            {
                MenuItemList[userChoice].DoWhenSelected();
            }

            while (userChoice != 0)
            {
                Console.WriteLine(
                    "=========================" +
                    Environment.NewLine +
                    Title +
                    Environment.NewLine +
                    "=========================");
                printItemList();
                Console.WriteLine("=========================");
                userChoice = getUserChoice();
                Console.Clear();
                if (userChoice != 0)
                {
                    MenuItemList[userChoice].DoWhenSelected();
                }
            }
        }

        private void printItemList()
        {
            List<MenuItem> menuItemListToPrint = new List<MenuItem>();
            string format = "{0}. {1}";

            foreach (MenuItem item in MenuItemList)
            {
                if (item.MenuItemIndex != 0)
                {
                    menuItemListToPrint.Add(item);
                }
            }

            foreach (MenuItem item in menuItemListToPrint)
            {
                Console.WriteLine(format, item.MenuItemIndex, item.Title);
            }

            Console.WriteLine(format, MenuItemList[0].MenuItemIndex, MenuItemList[0].Title);
        }

        private int getUserChoice()
        {
            int userChoice;
            string userChoiceString;

            Console.Write(
                "Please select one of the options above: " +
                Environment.NewLine);
            userChoiceString = Console.ReadLine();

            while (!int.TryParse(userChoiceString, out userChoice) || (userChoice < 0 || userChoice > MenuItemList.Count - 1))
            {
                Console.Write(
                        "Invalid Input, please try again!" +
                        Environment.NewLine);
                userChoiceString = Console.ReadLine();
            }

            return userChoice;
        }
    }
}
