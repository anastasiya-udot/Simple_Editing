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
    public partial class Form1 : Form
    {
        Graphics area;
        LinkedList<Figures> figuresList;
        int mouseDownCounter = 0;
        Point[] mouseLocations;

        public Form1()
        {
            InitializeComponent();
            this.area = this.CreateGraphics();
            MouseCounter_textBox.Text = mouseDownCounter.ToString();
        }

        private void AllFigures_Button_Click(object sender, EventArgs e)
        {
            figuresList = FiguresList.CreateFiguresList(Points_trackBar.Value);

            area.Clear(Color.White);

            for (LinkedListNode<Figures> Node = figuresList.First; Node != null; Node = Node.Next)
            {
                Node.Value.Draw(area);
            }
        }

        private void Ellipse_Button_Click(object sender, EventArgs e)
        {
            if (mouseDownCounter >= 2)
            {
                Point[] arrayEllipse = new Point[2];
                Array.Copy(mouseLocations, 0, arrayEllipse, 0, 2);
                Figures ellipse = new Ellipse(arrayEllipse);
                ellipse.Draw(area);
                mouseDownCounter = 0;
                MouseCounter_textBox.Text = mouseDownCounter.ToString();
            }
        }

        private void Polygon_Button_Click(object sender, EventArgs e)
        {
            if (mouseDownCounter >= 3)
            {
                Point[] arrayPolygon = new Point[mouseDownCounter];
                Array.Copy(mouseLocations, 0, arrayPolygon, 0, mouseDownCounter);
                Figures polygon = new Polygon(arrayPolygon);
                polygon.Draw(area);
                mouseDownCounter = 0;
                MouseCounter_textBox.Text = mouseDownCounter.ToString();
            }
        }

        private void Line_Button_Click(object sender, EventArgs e)
        {
            if (mouseDownCounter >= 2)
            {
                Point[] arrayLine = new Point[2];
                Array.Copy(mouseLocations, 0, arrayLine, 0, 2);
                Figures line = new Line(mouseLocations);
                line.Draw(area);
                mouseDownCounter = 0;
                MouseCounter_textBox.Text = mouseDownCounter.ToString();
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (mouseDownCounter == 0)
            {
                mouseLocations = new Point[6];
            }
            if (mouseDownCounter == 6)
            {
                mouseLocations = new Point[6];
                mouseDownCounter = 0;
            }
                mouseLocations[mouseDownCounter] = new Point(e.X, e.Y);
                mouseDownCounter++;
                MouseCounter_textBox.Text = mouseDownCounter.ToString();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            area.Clear(Color.White);
            mouseDownCounter = 0;
            MouseCounter_textBox.Text = mouseDownCounter.ToString();
        }
    }
}