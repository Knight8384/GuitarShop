using System;
using System.Collections.Generic;
using System.Text;
using Beginning_Project;

namespace Beginning_Project
{
    public class Guitar
    {

        private int numberOfStrings = 6;

        /// <summary>
        /// The length of the guitar neck, this is recorded in inches.
        /// </summary>
        /// 
        private double lengthOfNeck = 24;

        private int numberOfFrets = 22;

        private decimal price;

        private int rarity;

        private string brand;
        private double weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public decimal Price { get; internal set; }

        Random rndNumber = new Random();
        //Constructors - Are the starting 'method' of a object to define some of the data.
        //structure of a constructor: [scope] Guitar(parameters)
        public Guitar(string brand)
        {
            this.brand = brand;
            randomPrice();
            rarity = randomRarity();
        }
        public Guitar()
        {
            brand = randomBrand();
            price = randomPrice();
            rarity = randomRarity();
        }

        public void SetNumberOfStrings(int newStringCount)
        {
            numberOfStrings = newStringCount;
        }

        public int GetNumberOfStrings()
        {
            return numberOfStrings;
        }
        public string getBrand()
        {
            return brand;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        public decimal getPrice()
        {
            return price;
        }
        public decimal randomPrice()
        {
            price = rndNumber.Next(800);
            price = Math.Round(price / 10) * 10 - 1; //Rounds to nearest 10, Source: Taylor
            price += 0.99M; //Adds .99 to final price, Source: Taylor
            return price;
        }
        public string randomBrand()
        {
            int randomNumber = rndNumber.Next(6);
            if (randomNumber == 0)
            {
                brand = ("Homemade\t");
            }
            else if (randomNumber == 1)
            {
                brand = ("Fender\t");
            }
            else if (randomNumber == 2)
            {
                brand = ("Martin\t");
            }
            else if (randomNumber == 3)
            {
                brand = ("ESP\t \t");
            }
            else if (randomNumber == 4)
            {
                brand = ("Yamaha\t");
            }
            else if (randomNumber == 5)
            {
                brand = ("Seagull\t");
            }
            return brand;
        }
        public int randomRarity()
        {
            int randomNumber = rndNumber.Next(101);
            if (randomNumber < 15) // 0-15 = rarity 3
            {
                rarity = 3;
            }
            else if (randomNumber >= 15 && randomNumber < 55) //15-54 = rarity 2
            {
                rarity = 2;
            }
            else // 55-100 = rarity 1
            {
                rarity = 1;
            }
            return rarity; 
        }
        public int getRarity()
        {
            return rarity;
        }
        public void setPrice(int price)
        {
            this.price = price;
        }

    }
}
