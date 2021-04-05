using System;
using System.Collections.Generic;
using System.Text;

namespace EX4A_Farm
{
    class Mouse
    {
        private string mName;
        private string mEat;
        private string mColor;
        private string mSound;
        private string mProduct;

        public Mouse()
        {
            mName = "Jerry";
            mEat = "cheese";
            mColor = "grey";
            mSound = "sqeak";
            mProduct = "Annoy humans and is useless!";

        }
        public string getName()
        {
            return mName;
        }
        public string getFood()
        {
            return mEat;
        }
        public string getColor()
        {
            return mColor;
        }
        public string getSound()
        {
            return mSound;
        }
        public string getProduct()
        {
            return mProduct;
        }
    }
}
