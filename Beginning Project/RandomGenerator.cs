using System;
using System.Collections.Generic;
using System.Text;

namespace Beginning_Project
{
    public static class RandomNumberGen
    {
        private static Random random = new Random();

        public static string GetRandomOwner()
        {
            string ownerName;
            int randomNumber = random.Next(4);

            if (randomNumber == 0)
            {
                ownerName = "Zach";
                return ownerName;
            }
            else if (randomNumber == 1)
            {
                ownerName = "Taylor";
                return ownerName;
            }
            else if (randomNumber == 2)
            {
                ownerName = "Jacob";
                return ownerName;
            }
            else
            {
                ownerName = "Chris";
                return ownerName;
            }

        }
        public static string GetRandomBrand()
        {
            string guitarBrand;
            int randomBrand = random.Next(4);

            switch (randomBrand)
            {
                case 0:
                guitarBrand = "Fender";
                    break;
                case 1:
                    guitarBrand = "Taylor";
                    break;
                case 2:
                    guitarBrand = "ZachsGuitars";
                    break;
                default:
                    guitarBrand = "Squire";
                    break;
            }
            return guitarBrand;
        }

    }

}
