//using statements are used to tell the compiler which code we are using.
//using [namespace]

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Beginning_Project;

//Namespace is used to organize classes
//Format of making a namespace:
//namespace [name of the namespace]
namespace Beginning_Project
{
    //A class is used to organize methods and variables.
    //Format of making a class goes like this:
    //[Scope] class [Name of the class]
    class Person
    {
        //Format of a variable (inside of a class)
        //[Scope] [Data type] [Name];
        internal int height;

        // optionally: [Scope] [Data type] [Name] = [value];
        public static string hairColor = "Yellow";

        // the backslash \ is considered the escape character

        //other scopes: private and protected

        //A method is used to perform some action or code.
        //Format of a method:
        //[Scope] [Static or omit it] [Return type, use void to say there is no return] [Name of the method](parameter list)
        private static void Main(string[] args)
        {
            //Format of a variable (inside of a method)
            //[Data type] [Name];
            char characterNoDefaultValue;

            //optionally [Data type] [Name] = [value];
            double fractionalNumber = 0.54124125125124123;
            float smallerFractionalNumber = 0.54124125125124123f;
            char character = 'p';

            long longNumber = 1231235151251252312;
            int integerNumber = 124545;
            short smallInteger = 256;

            //Console.WriteLine(hairColor);
            //double roomTemperature = 40;
            //double convertedTemperature = TemperatureFahrenheitToCelcius(roomTemperature);
            //Console.WriteLine(convertedTemperature);

            double temp1 = 10;
            double temp2 = 72;
            double temp3 = 92;

            double average = TemperatureAverage(temp1, temp2, temp3);

            string foo = "10";
            string bar = "72";

            string foobar = foo + bar; //the term for adding strings together is called "concatination"
            string foobar2 = temp1.ToString();

            int basket1 = 10;
            int basket2 = 20;

            string appleCountString = (basket1 + basket2).ToString();

            string foobar3 = "I have this many apples: 10";
            string foobar4 = "I have this many apples: " + appleCountString;

            double input1 = 10;
            double input2 = 72;
            double input3 = 92;

            //Arrays are 0-indexed, so the first value starts at 0!
            //An array with a length 3, has 0, 1, 2 indices
            double[] array = new double[4];
            array[0] = 1;
            array[1] = 2;
            array[2] = 9;
            array[3] = 100;

            double arrayAverage = TemperatureAverage(array[0], array[1], array[2]);

            string[] stringArray = new string[3];
            stringArray[0] = "Hello World!";
            stringArray[1] = "123";
            //stringArray[2] is null

            string[] stringArraySecondName = stringArray;
            string str1 = stringArraySecondName[0];
            stringArraySecondName[0] = "444";

            string str2 = stringArray[0];

            string firstNameTaylor = "Taylor";

            string secondName = "Zach";

            string copyOfFirstName = firstNameTaylor;
            firstNameTaylor = secondName;

            secondName = "Jacob";

            string finalName = firstNameTaylor + " " + secondName + " " + copyOfFirstName;

            //Console.WriteLine(finalName);

            int first_Number = 100;
            int second_Number = 200;
            int third_Number = -25;
            int fourth_Number = 0;

            if (first_Number == second_Number && first_Number == -25)
            {
                Console.WriteLine("It's true!");
            }
            else if (third_Number > 0)
            {
                Console.WriteLine("Third number is less than zero.");
            }
            else if (fourth_Number != 0)
            {
                Console.WriteLine("Fourth number is 0");
            }
            else
            {
                //Console.WriteLine("They were all false.");
            }

            /*
            Console.WriteLine("Please type your first number.");
            string firstNumberString = Console.ReadLine();

            Console.WriteLine("Please type your second number.");
            string secondNumberString = Console.ReadLine();

            double firstNumber = double.Parse(firstNumberString);
            double secondNumber = double.Parse(secondNumberString);
            double doubleParse = double.Parse("0.333");
            float floatParse = float.Parse("0.333");
            decimal decimalParse = decimal.Parse("0.333");

            bool firstNumberPositive = IsOdd(firstNumber);

            Console.WriteLine("The result is: " + firstNumberPositive);

            Console.WriteLine("End of program.");
            */

            /*
            Console.WriteLine("This is a while loop:");
            int counter = 1;
            while (counter < 6)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("This is a do while loop:");
            counter = 1;
            do
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }
            while (counter < 6);

            Console.WriteLine("This is a for loop:");
            //the format of a for loop is like so:
            //for ([Create Variable Here]; [Conditional that determines when to leave the loop]; [Add to the variable to meet the conditional])
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("This is a foreach loop:");
            foreach (string s in stringArray)
            {
                if (s == null)
                {
                    Console.WriteLine("Null");
                }
                else
                {
                    Console.WriteLine(s);
                }
            }



            //Write a method that will sum the first 10 numbers in a loop that loops at least 10 times.
            //So 1+2+3+4+5+6+7+8+9+10 = 55 should returned.

            int methodResult = SumOfInts();
            Console.WriteLine(methodResult);
            */

            long[] longArray = new long[6];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;

            longArray[5]--;

            int firstIndex = 1;
            long lg = longArray[firstIndex];
            //Console.WriteLine(lg);

            foreach (long l in longArray)
            {
                //Console.WriteLine(l);
            }

            //This gets the number of elements (elements is general since arrays can be strings/numbers/etc) in an array.
            //int lengthOfArray = longArray.Length;

            //ZachForeachReplacement();

            //JacobReverseLoop();
            //ZachReverseLoop();

            string[] arrayToFill = new string[6];
            arrayToFill[0] = "A";
            arrayToFill[1] = "B";
            arrayToFill[2] = "C";
            arrayToFill[3] = null;
            arrayToFill[4] = "E";
            arrayToFill[5] = "F";

            //TODO: Make the below method.

            //TRY PARSE EXAMPLE
            /*
            string input = Console.ReadLine();

            int value;
            bool result = int.TryParse(input, out value);
            if (result)
            {

            }
            else
            {

            }
            */

            /*
            GuitarShop GuitarShop1 = new GuitarShop();
            Guitar guitar1 = new Guitar();
            Inventory player = new Inventory();
            List<Guitar> guitars = new List<Guitar>();
            guitars = player.getGuitarList();
            player.addGuitars(15);
            CheckGuitarsMenu(GuitarShop1, player);
            */

            VisitGuitarShop();

        }
        public static void VisitGuitarShop()
        {
            //Creates Player Inventory
            Inventory player = CreateInventory();
            //Creates and adds amount of guitars to shop
            GuitarShop GuitarShop1 = CreateGuitarShop();

            //Starts by displaying menu
            Console.WriteLine($"Hello! Welcome to {GuitarShop1.ReturnOwnerName()}'s Guitar Shop. Stay a while and listen.\n");
            // Displays Menu Options
            DisplayMenu();

            //Reads 1st input by user
            ReadInputMenu(GuitarShop1, player);

        }
        public static void ReadInputMenu(GuitarShop GuitarShop1, Inventory player)
        {
            Guitar[] guitars = new Guitar[1];
            guitars = GuitarShop1.getGuitars();
            List<Guitar> GuitarList = player.getGuitarList();

            string input = Console.ReadLine();
            int inputInt;
            bool result = int.TryParse(input, out inputInt);
            if (result == true && inputInt == 1)
            {
                if (guitars.Length != 0) //Checks if there are any guitars
                {
                    //Goes to guitar menu
                    Console.Clear();
                    displayGuitarsMenu(GuitarShop1, player);
                    ReadInputShop(GuitarShop1, player);
                }
                else //No Guitars
                {
                    OutOfGuitars(GuitarShop1, player);
                }
                
            }
            else if (result == true && inputInt == 3) //Check Guitars
            {
               //Kept looping 3 times before closing
                if (GuitarList.Count != 0)
                {
                    Console.Clear();
                    CheckGuitarsMenu(GuitarShop1, player);
                    ReadInputCheck(GuitarShop1, player);
                }
                else
                {
                    OutOfGuitars(GuitarShop1, player, false);
                }
            }
            else if (result == true && inputInt == 4)
            {
                //Exits the program
                Console.Clear();
                Console.WriteLine("Thanks for shopping!");
            }
            else
            {
                //Not an option
                RefreshMenu(GuitarShop1, player, true);
            }

            //else if (result == true && inputInt == 2) //Sell Guitars
            //{
            //if (player.guitarAmount > 0) // Checks if player has guitars
            //{
            //   Sell Guitars Shop Menu
            //   Sell Guitar Shop Input
            //}
            //else // Player doesn't have any guitars
            //{
            //   Console.WriteLine("You Don't Have any Guitars to sell")
            //   RefreshMenu
            //   ReadInput
            //}
            //}

        }
        public static void ReadInputShop(GuitarShop GuitarShop1, Inventory player)
        {
            Guitar[] guitars = new Guitar[1];
            guitars = GuitarShop1.getGuitars();
            List<Guitar> playerGuitar = new List<Guitar>();
            playerGuitar = player.getGuitarList();

            string input1 = Console.ReadLine();
            int inputNumber;
            bool result = int.TryParse(input1, out inputNumber);
            if (inputNumber - 1 >= 0 && inputNumber - 1 <= guitars.Length - 1) //Checks if within guitars length and zero
            {
                if (player.getBalance() >= guitars[inputNumber - 1].getPrice()) //Checks if player has enough money
                {
                    player.subtractBalance(guitars[inputNumber - 1].getPrice());
                    playerGuitar.Add(guitars[inputNumber - 1]);
                    GuitarShop1.RemoveGuitar(guitars[inputNumber - 1]);
                    
                    if (guitars.Length != 0) // Checks if theres any guitars left before refreshing
                    {
                        RefreshShop(GuitarShop1, player); //Refreshes without "Not an option" 
                    }
                    else //Boots back to menu if no more guitars
                    {
                        OutOfGuitars(GuitarShop1, player);
                    }
                }
                else //Not Enough Money
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, I can't give credit, come back when you're a little mmmmh richer. \n");
                    displayGuitarsMenu(GuitarShop1, player);
                    ReadInputShop(GuitarShop1, player);
                }
            }
            else if (inputNumber == guitars.Length + 1) //If input is equal to final element number, or exit option
            {
                RefreshMenu(GuitarShop1, player); //Returns to menu, false meaning that it won't print "Not an option"
            }
            else
            {
                RefreshShop(GuitarShop1, player, true); //Refresh with "Not an option"
            }
        }
        public static void RefreshMenu(GuitarShop GuitarShop1, Inventory player, bool reenter = false)
        { //Reenter is whether the user starts on menu(false/default) or arrives there from another menu(true).
            if(reenter == true)
            {
                Console.Clear();
                Console.WriteLine("Not an option, please choose again.\n");
                DisplayMenu();
                ReadInputMenu(GuitarShop1, player);
            }
            else //Re-Displays menu without saying incorrect input
            {
                Console.Clear();
                DisplayMenu();
                ReadInputMenu(GuitarShop1, player);
            }
        }
        public static void RefreshShop(GuitarShop GuitarShop1, Inventory player, bool reenter = false)
        { //Same idea used in RefreshMenu

            Guitar[] guitars = new Guitar[1]; //References the list of guitars to a local array
            guitars = GuitarShop1.getGuitars(); //Gets GuitarShop's guitars

            if (reenter == true) //Refreshes shop menu if inncorrect input
            {
                Console.Clear();
                Console.WriteLine("Not an option, please choose again.\n");
                displayGuitarsMenu(GuitarShop1, player);
                ReadInputShop(GuitarShop1, player);
            }
            else //Refreshes shop menu if arrive
            {
                Console.Clear();
                displayGuitarsMenu(GuitarShop1, player);
                //Exit Loop Occured Here
                if (guitars.Length != 0) //Checks if theres anymore guitars
                {
                    ReadInputShop(GuitarShop1, player);
                } //No more guitars, so exit
                else
                {
                    return;
                }
            }
        }
        public static void OutOfGuitars(GuitarShop GuitarShop1, Inventory player, bool state = true)
        { //OutOfGuitars(GuitarShop1, player); State is whether its denoting to the shop(true/default) or player(false)
            if (state == true) //If shop has no guitars
            {
                Console.Clear();
                Console.WriteLine("Sorry, We seem to be all out of guitars. Thank you for your service!\n");
                Console.WriteLine("Enter Any Key To Continue");
                Console.ReadLine(); //Waits for user input
                Console.Clear();
                DisplayMenu(); //Re-Displays menu
                ReadInputMenu(GuitarShop1, player);
            }
            else //If player has no guitars
            {
                Console.Clear();
                Console.WriteLine("You don't have any guitars!\n");
                Console.WriteLine("Enter Any Key To Continue");
                Console.ReadLine();
                RefreshMenu(GuitarShop1, player, false);
            }
        }
    public static void DisplayMenu()
        {
           Console.WriteLine("What would you like to do?");
           Console.WriteLine("1) Buy Guitars");
           Console.WriteLine("2) Sell Guitars");
           Console.WriteLine("3) Check Guitars");
           Console.WriteLine("4) Exit");
            
        }
        public static void displayGuitarsMenu(GuitarShop GuitarShop1, Inventory player)
        {
            int guitarListNumber = 1; //Lists the guitars starting from 1

            Guitar[] guitars = new Guitar[1]; //References the list of guitars to a local array
            guitars = GuitarShop1.getGuitars(); //Gets inputed GuitarShop's guitars

            Console.WriteLine($"You find that you have ${player.getBalance()} left."); //Displays player's money
            Console.WriteLine("Here is a selection of our finest guitars:\n"); //Prompts the user to buy guitars

            if (guitars.Length != 0) //If there are guitars then display otherwise show prompt of no guitars
            {
                for (int i = 0; i < guitars.Length; i++) //Loops through each guitar and displays information about them
                {
                    if (guitars[i] != null) //If guitar doesn't exist then don't display
                    {
                        Console.WriteLine($"Guitar {guitarListNumber} / Brand: {guitars[i].getBrand()} Price: ${guitars[i].getPrice()}");
                        guitarListNumber = guitarListNumber + 1;
                    }
                }
                Console.WriteLine("\n" + (guitars.Length + 1) + ") Back Out "); //Last Option to back out
            }
            else //No guitars left
            {
                OutOfGuitars(GuitarShop1, player);
            }
        }

        public static GuitarShop CreateGuitarShop()
        {
            GuitarShop GuitarShop1 = new GuitarShop();
            GuitarShop1.addMultiGuitars(9);
            return GuitarShop1;

        }
        public static Inventory CreateInventory()
        {
            Inventory player = new Inventory();
            player.addBalance(1000);
            return player;

        }

        public static void CheckGuitarsMenu(GuitarShop GuitarShop1, Inventory player)
        { //CheckGuitarsMenu(GuitarShop1, player)
            List<Guitar> GuitarList = player.getGuitarList();
            int guitarListNumber = 1; //Lists the guitars starting from 1
            if (GuitarList.Count != 0) //If there are guitars then run
            {
                Console.WriteLine($"You check out your collection of guitars and find: \n");
                for (int i = 0; i < GuitarList.Count; i++) //For each guitar in player inventory prints its number and data
                {
                    Console.WriteLine($"Guitar {guitarListNumber} | Brand: {GuitarList[i].getBrand()}/ Price: ${GuitarList[i].getPrice()}/ Rarity: {GuitarList[i].getRarity()}"); //Prints guitar data
                    guitarListNumber = guitarListNumber + 1; //Incerments guitar number by one
                }
                Console.WriteLine("\n" + (GuitarList.Count + 1) + ") Back Out ");
            }
            else //No Guitars in player inventory
            {
                OutOfGuitars(GuitarShop1, player, false);
            }
        }
        public static void ReadInputCheck(GuitarShop GuitarShop1, Inventory player)
        { //ReadInputCheck(GuitarShop1, player);
            List<Guitar> GuitarList = player.getGuitarList();

            string input1 = Console.ReadLine();
            int inputNumber;
            bool result = int.TryParse(input1, out inputNumber);
            if (inputNumber - 1 >= 0 && inputNumber - 1 <= GuitarList.Count - 1) //Input is one of the guitars
            {
                Console.Clear();
                Console.WriteLine("Sorry, they're NFT guitars so no inspecting them.\n");
                RefreshCheck(GuitarShop1, player);
            }
            else if (inputNumber == GuitarList.Count + 1) //Input is last option, which is exit
            {
                RefreshMenu(GuitarShop1, player, false); //Goes back to main menu
            }
            else //If not a correct input
            {
                RefreshCheck(GuitarShop1, player, true);
            }
        }
        public static void RefreshCheck(GuitarShop GuitarShop1, Inventory player, bool reenter = false)
        {
            //Reenter is whether the user starts on menu(true/default) or arrives there from another menu(false).
            if (reenter == true)
            {
                Console.Clear();
                Console.WriteLine("Not an option, please choose again.\n");
                CheckGuitarsMenu(GuitarShop1, player);
                ReadInputCheck(GuitarShop1, player);
            }
            else //Re-Displays menu without saying incorrect input
            {
                CheckGuitarsMenu(GuitarShop1, player);
                ReadInputCheck(GuitarShop1, player);
            }
        }

        public static void SellGuitarMenu()
        {

        }











        public static string[] AddElement(string newStr, string[] array)
        {
            int newSize = array.Length + 1;
            string[] newArray = new string[newSize];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = newStr;
            return newArray;
        }

        public static void swapString(string[] array1, int swapOne, int swapTwo)
        {
            swapOne--;
            swapTwo--;
            string string1 = array1[swapOne];
            array1[swapOne] = array1[swapTwo];
            array1[swapTwo] = string1;
        }

        public static void GuitarShopObjctPractice()
        {
            GuitarShop myShop = new GuitarShop();
            string brand = "Fender";
            Guitar myGuitar = new Guitar(brand);
            myShop.AddGuitar(myGuitar);


            Console.WriteLine("hi");
        }


        public static void JacobReverseLoop()
        {
            string[] greetings = new string[4];
            greetings[0] = "Hello!";
            greetings[1] = "Welcome!";
            greetings[2] = "Hello World!";
            greetings[3] = "Guten Tag!";

            string s = greetings[0];
            Console.WriteLine(s);

            s = greetings[1];
            Console.WriteLine(s);

            s = greetings[2];
            Console.WriteLine(s);

            Console.WriteLine("The Loop's Output is below:");

            string tempS;
            int i2 = greetings.Length;
            for (int i = 0; i < greetings.Length; i++)
            {
                i2--;
                tempS = greetings[i2];
                Console.WriteLine(tempS);
            }
        }

        public static void ZachReverseLoop()
        {
            string[] greetings = new string[4];
            greetings[0] = "Hello!";
            greetings[1] = "Welcome!";
            greetings[2] = "Hello World!";
            greetings[3] = "This is the fourth greeting.";

            /*string s = greetings[0];
            Console.WriteLine(s);

            s = greetings[1];
            Console.WriteLine(s);

            s = greetings[2];
            Console.WriteLine(s);
            */
            // Console.WriteLine("The Loop's Output is below:");


            string tempS;

            for (int i = greetings.Length - 1; i > -1; i--)
            {
                //s = greetings[1];
                tempS = greetings[i];
                Console.WriteLine(tempS);
            }
        }

        public static void JacobForeachReplacement()
        {
            long[] longArray = new long[7];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;
            longArray[6] = long.MaxValue;

            int arrayLength = longArray.Length;
            int arrayLength2 = 0;

            for (long l = 0; l < arrayLength; l++)
            {
                Console.WriteLine(longArray[arrayLength2]);
                arrayLength2++;
            }
        }

        public static void ZachForeachReplacement()
        {
            long[] longArray = new long[6];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;

            int lengthOfArray = longArray.Length;
            int firstIndex = 0;
            long l1;

            for (long i = 0; i < lengthOfArray; i++)
            {
                l1 = longArray[firstIndex];
                firstIndex++;
                Console.WriteLine(l1);
            }
        }

        public static void TaylorForeachReplacement()
        {
            long[] longArray = new long[7];
            longArray[0] = 1000;
            longArray[1] = 300;
            longArray[2] = 900;
            longArray[3] = 420;
            longArray[4] = 750;
            longArray[5] = -666;
            longArray[6] = long.MaxValue;

            //three sections of for loop
            //make the counter variable
            //define the condition to exit the loop
            //define how to change the counter variable
            for (int i = 0; i < longArray.Length; i++)
            {
                long l = longArray[i];
                Console.WriteLine(l);
            }
        }

        public static int SumOfInts()
        {
            int Sum = 0;
            int Ints = 1;
            while (Sum < 55)
            {
                Sum = (Sum + Ints);
                Ints++;
            }

            return Sum;
        }

        public static double TemperatureFahrenheitToCelcius(double fahrenheit)
        {
            double celcius = (fahrenheit - 32) * .5556;

            return celcius;
        }


        public static double TemperatureFahrenheitToKelvin(double fahrenheit)
        {
            double celcius = TemperatureFahrenheitToCelcius(fahrenheit);
            double kelvin = celcius + 273;
            return kelvin;
        }

        public static double TemperatureAverage(double temperature1, double temperature2, double temperature3)
        {
            double finalNumber = (temperature1 + temperature2 + temperature3) / 3;

            return finalNumber;
        }

        public static bool IsOdd(double number)
        {

            double FinalNumber = 1;
            FinalNumber = number % 2;
            if (FinalNumber == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
        }

        public static string FillGapZach(string gapFill, string[] arrayToFill) //This is the second for fillgap method
        {
            gapFill = "123Skipafew";
            string nullFinder;
            for (int i = 0; i < arrayToFill.Length; i++)
            {
                if (arrayToFill[i] == null)
                {
                    nullFinder = gapFill;
                    Console.WriteLine(nullFinder);
                }
                else
                {
                    Console.WriteLine(arrayToFill[i]);
                }

            }
            nullFinder = null;
            return nullFinder;
        }

        public static void FillGap(string gap, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = gap;
                }
            }
        }

    }


}