using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning_Project
{
    public static class ShopGame
    {

        public static void Start()
        {
            bool running = true;

            while (running)
            {
                DisplayScreen();
                int userInput = GetInput();
                MainLogic(userInput);
            }

        }
        public static void DisplayScreen()
        {

        }
        public static int GetInput()
        {
            bool invalidInput = true;

            while (invalidInput) //Always true starting
            {
                string input = Console.ReadLine(); //Reads input

                int value; //Whats the user inputs
                bool result = !int.TryParse(input, out value); //Parses input

                if (invalidInput) //If input is not a number then run
                {
                    Console.WriteLine("Wrong Input");
                }
                else //Else input is value and a number
                {
                    return value;
                }
            }
            return 0; //Failsafe
        }
        public static void MainLogic(int input)
        {
            
        }
    }
}
