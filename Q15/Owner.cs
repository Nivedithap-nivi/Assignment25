using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    public class Owner
    {
        protected string ownerName;
    }

    public class Car : Owner
    {
        internal double price;

        private string bodyStyle;

        public string BodyStyle
        {
            get { return bodyStyle; }
            set { bodyStyle = value; }
        }

        public bool ValidateBodyStyle(string bodyStyle)
        {
            if (bodyStyle == "SUV" || bodyStyle == "Sedan")
            {
                return true;
            }
            return false;
        }

        public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
                return price - (price * 0.10);
            }
            else if (bodyStyle == "Sedan")
            {
                return price - (price * 0.25);
            }
            else
            {
                return 0;
            }
        }

        public void SetOwnerName(string name)
        {
            ownerName = name;
        }
    }
}
