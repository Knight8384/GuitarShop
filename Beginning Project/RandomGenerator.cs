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

            switch (randomNumber)
            {
                case 0:
                    ownerName = "Zach";
                    break;
                case 1:
                    ownerName = "Taylor";
                    break;
                case 2:
                    ownerName = "Jacob";
                    break;
                default:
                    ownerName = "Chris";
                    break;
            }
            return ownerName;
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
