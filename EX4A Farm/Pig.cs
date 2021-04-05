using System;
using System.Collections.Generic;
using System.Text;

namespace EX4A_Farm
{
    class Pig
    {
        private string pName;
        private string pEat;
        private string pColor;
        private string pSound;
        private string pProduct;


        public Pig()
        {
            pName = "piglet";
            pEat = "leftovers";
            pColor = "pink";
            pSound = "oink";
            pProduct = "bacon";

        }
        public string getName()
        {
            return pName;
        }
        public string getFood()
        {
            return pEat;
        }
        public string getColor()
        {
            return pColor;
        }
        public string getSound()
        {
            return pSound;
        }
        public string getProduct()
        {
            return pProduct;
        }
    }
}
