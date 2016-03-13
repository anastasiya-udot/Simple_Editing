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

    class Figures: Control
    {
        protected Point[] pointsArray;
        public Point[] PointsArray
        {
            get { return pointsArray; }
            set { pointsArray = value; }
        }
        public Figures()
        {
            Size = new Size(1000, 1000);
        }
        public virtual void Draw(Graphics area)
        {
            
        }

    }
}
