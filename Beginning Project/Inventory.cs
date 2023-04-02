using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Beginning_Project
{
    public class Inventory
    {
        List<Guitar> playerGuitars = new List<Guitar>(); 
        //Property
        public decimal Price
        {
            get { return playerMoney; }
            set { playerMoney = value; }
        }
        private decimal playerMoney = 0;

        public Inventory()
        {

        }
        public List<Guitar> getGuitarList()
        {
            return playerGuitars;
        }
        public decimal getBalance()
        {
            return playerMoney;
        }
        public void subtractBalance(decimal amount)
        {
            playerMoney = playerMoney - amount;
        }
        public void addBalance(decimal amount)
        {
            playerMoney = playerMoney + amount;
        }
        public void addGuitars(int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                playerGuitars.Add(new Guitar());
            }
        }
    }
}
