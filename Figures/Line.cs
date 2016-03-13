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
    class Line: Figures
    {
        Graphics area;

        public Line(Point[] pointsArray)
        {
            this.PointsArray = pointsArray;
        }
        public override void Draw(Graphics area)
        {
            this.area = area;
            Pen MyPen = new Pen(Color.Red);         
            area.DrawLine(MyPen, pointsArray[0], pointsArray[1]);
        }
    }
}
