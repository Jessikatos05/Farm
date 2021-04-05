using System;
using System.Collections.Generic;
using System.Text;

namespace EX4A_Farm
{
    class Horse
    {
        private string hName;
        private string hEat;
        private string hColor;
        private string hSound;
        private string hProduct;

    public Horse()
        {
            hName = "Joey";
            hEat = "Hay";
            hColor = "Brown";
            hSound = "neigh";
            hProduct = "Hourse racing";

        }
        public string getName()
        {
            return hName;
        }
        public string getFood()
        {
            return hEat;
        }
        public string getColor()
        {
            return hColor;
        }
        public string getSound()
        {
            return hSound;
        }
        public string getProduct()
        {
            return hProduct;
        }
    }
}
