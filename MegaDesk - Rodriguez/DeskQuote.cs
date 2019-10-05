using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaDesk___Rodriguez
{
    class DeskQuote
    {
       public string customerName;
       public DateTime QuoteDate;
        //create an instance of the Desk class.
       public Desk Desk = new Desk();

        //Pricing Structure Variables
        const double DRAWER_PRICE = 50;
        const double BASE_PRICE = 200;
        //Surface materials_ids
        const double OAK_ID = 1;
        const double LAMINATE_ID = 2;
        const double PINE_ID = 3;
        const double ROSEWOOD_ID = 4;
        const double VENEER_ID = 5;

        //Rush Order Constants
        const int _3_DAYS = 3;
        const int _5_DAYS = 5;
        const int _7_DAYS = 7;

        //RushOrder
        public double rushOrderDays;
        public double rushOrderPrice;
        //Surface Material Price
        double materialPrice = 0;

        public DeskQuote(double width, double depth, int numberDrawer, int surfaceMaterials)
        {

        }
    }
}
