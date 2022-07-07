using System.Drawing;
using System.Windows.Forms;

/*
 * Определяет треугольник
 * и действия с ним
 */

namespace OAiP_laba
{
    class Triangle : Figure
    {

        public Triangle()
        {

            N = 3;
            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, 50);
            points[2] = new Point(50, 0);

            Type = "Triangle";

        }

        public Triangle(Point a, Point b, Point c)
        {

            N = 3;
            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = a;
            points[1] = b;
            points[2] = c;

            Type = "Triangle";

        }
        //установка вершин треугольника
        public override void set(Point[] point)
        {

            points[0] = point[0];
            points[1] = point[1];
            points[2] = point[2];

        }
        //отрисовка треугольника
        public override void show(PaintEventArgs e)
        {

            e.Graphics.DrawLine(new Pen(Color.Black), points[0].getX(), points[0].getY(), points[1].getX(), points[1].getY());
            e.Graphics.DrawLine(new Pen(Color.Black), points[0].getX(), points[0].getY(), points[2].getX(), points[2].getY());
            e.Graphics.DrawLine(new Pen(Color.Black), points[2].getX(), points[2].getY(), points[1].getX(), points[1].getY());

        }
    }
}
