using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neeley_MegaDesk1._0
{
    class Desk
    {
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumDrawers { get; set; }

        public SurfaceMaterial Material { get; set; }


        public int CalculateSurfaceArea()
        {
            return DeskWidth * DeskDepth;
        }
    }

    

}
public enum SurfaceMaterial
{
    Laminate, Oak, Rosewood, Veneer, Pine
}
