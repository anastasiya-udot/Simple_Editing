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
    class Ellipse : Figures
    {
        Graphics area;
        public Ellipse(Point[] pointsArray)
        {
            this.PointsArray = pointsArray;
        }
        public override void Draw(Graphics area)
        {
            this.area = area;
            int width, heigth, X, Y;
            Pen MyPen = new Pen(Color.Green);

            width = pointsArray[1].X - pointsArray[0].X;
            if (width < 0)
            {
                width = pointsArray[0].X - pointsArray[1].X;
            }
            X = pointsArray[0].X - width;
            width =  width * 2;

            heigth = pointsArray[1].Y - pointsArray[0].X;
            if (heigth < 0)
            {
                heigth = pointsArray[0].Y - pointsArray[1].Y;
            }
            Y = pointsArray[0].Y - heigth;
            heigth = heigth * 2;

            Point CornerLU = new Point(X, Y);
            area.DrawEllipse(MyPen, CornerLU.X, CornerLU.Y, width, heigth);
        }
    }
}
