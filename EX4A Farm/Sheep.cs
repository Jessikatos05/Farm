using System;
using System.Collections.Generic;
using System.Text;

namespace EX4A_Farm
{
    class Sheep
    {
        private string sName;
        private string sEat;
        private string sColor;
        private string sSound;
        private string sProduct;

        public Sheep()
        {
            sName = "Larry";
            sEat = "grass";
            sColor = "white";
            sSound = "baaa";
            sProduct = "fur to make clothing";

        }
        public string getName()
        {
            return sName;
        }
        public string getFood()
        {
            return sEat;
        }
        public string getColor()
        {
            return sColor;
        }
        public string getSound()
        {
            return sSound;
        }
        public string getProduct()
        {
            return sProduct;
        }
    }
}
