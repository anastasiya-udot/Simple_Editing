using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    class Polygon : Figures
    {
        Graphics area;

        public Polygon(Point[] pointsArray)
        {
            this.PointsArray = pointsArray; 
        }
        public override void Draw(Graphics area)
        {
            this.area = area;
            Pen MyPen = new Pen(Color.Blue);
            area.DrawPolygon(MyPen, pointsArray);         
        }
    }
}
