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
    static class FiguresList
    {
        private static Point[] GeneratePointsPolygon(int number)
        {
            Point[] array = new Point[number];
            Random xRand = new Random(DateTime.Now.Millisecond), 
                   yRand = new Random(); ;
            int X, Y;
            for (int currentPoint = 0; currentPoint < (number); currentPoint++)
            {     
                X = xRand.Next(0, 500);
                Y = yRand.Next(0, 500);

                array[currentPoint] = new Point(X, Y);
            }

            return array;
        }

        private static Point[] GeneratePointsEllipse()
        {
            Point[] array = new Point[2];

            Random xRand = new Random(),
                   yRand = new Random(); 
            int Xcorner, Ycorner;
            Xcorner = xRand.Next(0, 500);
            Ycorner = yRand.Next(0, 500);
            array[1] = new Point(Xcorner, Ycorner);

            Random wDist = new Random(),
                   hDist = new Random();
            int Xcenter, Ycenter;
            Xcenter = Xcorner + wDist.Next(0, 100);
            Ycenter = Ycorner + hDist.Next(0, 100);

            array[0] = new Point(Xcenter, Ycenter);
            return array;
        }

        private static Point[] GeneratePointsLine()
        {
            Point[] array = new Point[2];
            Random xRand = new Random(DateTime.Now.Millisecond + 100),
                   yRand = new Random(); ;
            int X, Y;
            for (int currentPoint = 0; currentPoint < 2; currentPoint++)
            {
                X = xRand.Next(0, 500);
                Y = yRand.Next(0, 500);

                array[currentPoint] = new Point(X, Y);
            }
            return array;
        }

        public static LinkedList<Figures> CreateFiguresList(int pointsNumber)
        {
            Point[] pointsArrayPolygon= GeneratePointsPolygon(pointsNumber);
            Point[] pointsArrayEllipse = GeneratePointsEllipse();
            Point[] pointsArrayLine = GeneratePointsLine();

            LinkedList<Figures> figuresList = new LinkedList<Figures>();
            figuresList.AddFirst(new Line(pointsArrayLine));
            figuresList.AddFirst(new Ellipse(pointsArrayEllipse));
            figuresList.AddFirst(new Polygon(pointsArrayPolygon));

            return figuresList;
        }

    }
}
