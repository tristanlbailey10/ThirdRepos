using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ticketing
{
    public class TicketPrice
    {
        private int section;
        private int quantity;
        private int discount;
        private decimal amountDue;
        private decimal mPrice;

        const decimal mdecBalcony = 35.5m;
        const decimal mdecGeneral = 28.75m;
        const decimal mdecBox = 62.0m;
        const decimal mdecSDiscount = 5.0m;
        const decimal mdecChildDiscount = 10.0m;

        private int Section
        {
            get { return section; }
            set { section = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public decimal AmountDue
        {
            get { return amountDue; }
            set { amountDue = value; }
        }

        // Constructor for TicketPrice
        public TicketPrice(int section, int quantity, int discount)
        {
            Section = section;
            Quantity = quantity;
            Discount = discount;
            AmountDue = amountDue;
        }

        public void calculatePrice()
        {

            switch (section)
            {
                case 1:
                    mPrice = mdecBalcony;
                    break;
                case 2:
                    mPrice = mdecGeneral;
                    break;
                case 3:
                    mPrice = mdecBox;
                    break;
            }
            //if (discount)
            //{ mPrice -= mdecSDiscount; }
            switch (discount)
            {
                case 0:
                    break;
                case 1:
                    mPrice -= mdecSDiscount;
                    break;
                case 2:
                    mPrice -= mdecChildDiscount;
                    break;
            }
            //mPrice -= discount;

            AmountDue = mPrice * quantity;

        }
    }
}
