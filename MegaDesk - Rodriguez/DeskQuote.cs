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
        const double DSKTP_SURFACE_AREA_PRICE = 1;
        //Surface materials_ids
        const double OAK_ID = 1;
        const double LAMINATE_ID = 2;
        const double PINE_ID = 3;
        const double ROSEWOOD_ID = 4;
        const double VENEER_ID = 5;

        //Surface Values
        const int OAK_PRICE = 200;
        const int LAMINATE_PRICE = 100;
        const int PINE_PRICE = 50;
        const int ROSEWOOD_PRICE = 300;
        const int VENEER_PRICE = 125;

        //RushOrder
        public int RushOrderDays;
        public double RushOrderPrice;

        //Rush Order Constants
        const int _3_DAYS = 3;
        const int _5_DAYS = 5;
        const int _7_DAYS = 7;

        //Surface Material Price
        double materialPrice = 0;

        //Final Price
        double finalPrice;

        public DeskQuote(string theCustomer, DateTime quoteDate, double Width, double Depth, int drawers,  DesktopMaterials surfaceMaterials, int rushOrderDays)
        {
            customerName = theCustomer;
            QuoteDate = quoteDate;
            Desk.Width = Width;
            Desk.Depth = Depth;
            Desk.NumberDrawer = drawers;
            Desk.DesktopMaterials = surfaceMaterials;
            RushOrderDays = rushOrderDays;

            Desk.DeskArea = Desk.Width * Desk.Depth;

        }

        public int ComputeQuote()
        {
            materialPrice =  BASE_PRICE * DSKTP_SURFACE_AREA_PRICE + (DRAWER_PRICE * numberdrawer) + materialprice + rushorderprice;
        }

      
    }
}
