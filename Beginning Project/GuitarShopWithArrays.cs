﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning_Project
{
    /// <summary>
    /// A class to sell guitars
    /// </summary>
    public class GuitarShopWithArrays  
    {
        private Guitar[] guitars = new Guitar[1];
        private Random rand = new Random();
        private string ownerName;

        public string ReturnOwnerName()
        {
            randomName();
            return ownerName;
        }
        public void addMultiGuitars(int amount) //Adds Multiple guitars
        {
            for (int i = 0; i < amount; i++)
            {
                Guitar newGuitar = new Guitar();
                int randomNumber = rand.Next(6);
                if (randomNumber == 0)
                {
                    newGuitar.SetBrand("Homemade /");
                }
                else if (randomNumber == 1)
                {
                    newGuitar.SetBrand("Fender   /");
                    newGuitar.setPrice(rand.Next(75, 800)); //Sets the price range for the guitars
                }
                else if (randomNumber == 2)
                {
                    newGuitar.SetBrand("Martin   /");
                    newGuitar.setPrice(rand.Next(90, 800));
                }
                else if (randomNumber == 3)
                {
                    newGuitar.SetBrand("ESP      /");
                    newGuitar.setPrice(rand.Next(25, 800));
                }
                else if (randomNumber == 4)
                {
                    newGuitar.SetBrand("Yamaha   /");
                    newGuitar.setPrice(rand.Next(75, 800));
                }
                else if (randomNumber == 5)
                {
                    newGuitar.SetBrand("Seagull  /");
                    newGuitar.setPrice(rand.Next(250, 2500));
                }
                AddGuitar(newGuitar);
            }
        }

        public void AddGuitar(Guitar guitar)
        {
            Guitar newGuitar = new Guitar();
            newGuitar.SetBrand("Guitar" + 1);

            bool flag = false;
            for (int i = 0; i < guitars.Length; i++)
            {
                if (guitars[i] == null)
                {
                    guitars[i] = guitar;
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                int newSize = guitars.Length + 1;
                Guitar[] newArray = new Guitar[newSize];
                for (int i = 0; i < guitars.Length; i++)
                {
                    newArray[i] = guitars[i];
                }
                newArray[newArray.Length - 1] = guitar;
                guitars = newArray;
            }

        }
        /// <summary>
        /// Removes selected guitar from guitar shop array using index number
        /// </summary>
        /// <param name="index">Number of guitar on brand</param>
        public void RemoveGuitar(int index)
        {
            for (int i = 0; i < guitars.Length; i++)
            {
                if (i == index)
                {
                    for (int j = index; j < guitars.Length; j++)
                    {
                        if (j == guitars.Length - 1)
                        {
                            guitars[j] = null;
                        }
                        else
                        {
                            guitars[j] = guitars[j + 1];
                        }
                    }
                    int newSize = guitars.Length - 1;
                    Guitar[] newArray = new Guitar[newSize];
                    for (int k = 0; k < guitars.Length - 1; k++)
                    {
                        newArray[k] = guitars[k];
                    }
                    guitars = newArray;
                }
            }
        }
        /// <summary>
        /// Removes exact guitar from guitar shop array
        /// </summary>
        /// <param name="guitar">Specific guitar wanted removed</param>
        public void RemoveGuitar(Guitar guitar)
        {
            for (int i = 0; i < guitars.Length; i++)
            {
                if (guitars[i] == guitar)
                {
                    for (int j = i; j < guitars.Length; j++)
                    {
                        if (j == guitars.Length - 1) //Checks if its the last element
                        {
                            guitars[j] = null;
                            break;
                        }
                        else
                        {
                            guitars[j] = guitars[j + 1]; //Assigns element to the one above it
                        }
                    }
                    int newSize = guitars.Length - 1; //One less length to cut off null
                    Guitar[] newArray = new Guitar[newSize];
                    for (int k = 0; k < guitars.Length - 1; k++)
                    {
                        newArray[k] = guitars[k];
                    }
                    guitars = newArray;
                }
            }
        }
        /**
        public void displayGuitarBrands()
        {

            for (int i = 0; i < guitars.Length; i++)
            {
                if (guitars[i] != null)
                {
                    Console.WriteLine(guitars[i].getBrand());
                }
                else
                {
                    Console.WriteLine("null");
                }
            }
        }
        */
        public Guitar[] getGuitars()
        {
            return guitars;
        }
        public string randomName()
        {
            int number = rand.Next(4);
            if (number == 0)
            {
                ownerName = "Jacob";
            }
            else if(number == 1)
            {
                ownerName = "Zach";
            }
            else if(number == 2)
            {
                ownerName = "Taylor";
            }
            else
            {
                ownerName = "Chris";
            }
            return ownerName;
        }
    }
}



