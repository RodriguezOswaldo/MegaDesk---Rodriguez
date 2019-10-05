using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk___Rodriguez
{

    class Desk
    {
        double width { get; set; }
        double depth { get; set; }
        int numberDrawer { get; set; }
        DesktopMaterials SurfaceMaterial { get; set; }

    }
    enum DesktopMaterials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };
    /*
    public static void getDesk(double width,
                double depth,
                int numberDrawer,
                int surfaceMaterial
        )
    {

        Console.WriteLine("type in Desk Width in inches");
        width = double.Parse(Console.ReadLine());
        Console.WriteLine("type in Desk depth in inches");
        depth = double.Parse(Console.ReadLine());
        Console.WriteLine("type in the number of drawers you want your desk with");
        numberDrawer = int.Parse(Console.ReadLine());
        Console.WriteLine("Select the desire Surface Material");
        Console.WriteLine("1] laminate - 2]oak - 3] rosewood - 4] veneer - 5] pine");

        surfaceMaterial = int.Parse(Console.ReadLine());

    }     
}*/


}
