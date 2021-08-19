using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceCountSpaces : ISelectInterface
    {
        public void Excute()
        {
            Console.WriteLine("Please write a sentence: ");
            string userInput = Console.ReadLine();
            int numberOfSpacesInSentence = numberOfSpaces(userInput);
            Console.WriteLine("Number of Spaces is: {0}", numberOfSpacesInSentence);
        }

        private int numberOfSpaces(string i_UserInput)
        {
            int countSpaces = 0;
            for (int i = 0; i < i_UserInput.Length; i++)
            {
                if (i_UserInput[i] == ' ')
                {
                    countSpaces++;
                }
            }

            return countSpaces;
        }
    }
}
