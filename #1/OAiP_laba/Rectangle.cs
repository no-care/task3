using System.Drawing;
using System.Windows.Forms;

/*
 * Определяет прямоугольник
 * и действия с ним
 */

namespace OAiP_laba
{
    class Rectangle : Figure
    {
        
        public Rectangle()
        {

            N = 4;
            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, 50);
            points[2] = new Point(50, 0);
            points[3] = new Point(50, 50);

            Type = "Rectangle";

        }

        public Rectangle(Point[] point)
        {

            N = 4;
            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = point[0];
            points[1] = point[1];
            points[2] = point[2];
            points[3] = point[3];

            Type = "Rectangle";

        }
        //установка координат вершин прямоугольника
        public override void set(Point[] point)
        {

            points[0] = point[0];
            points[1] = point[1];
            points[2] = point[2];
            points[3] = point[3];

        }
        //отрисовка прямоугольника
        public override void show(PaintEventArgs e)
        {

            e.Graphics.DrawLine(new Pen(Color.Black), points[0].getX(), points[0].getY(), points[1].getX(), points[1].getY());
            e.Graphics.DrawLine(new Pen(Color.Black), points[1].getX(), points[1].getY(), points[2].getX(), points[2].getY());
            e.Graphics.DrawLine(new Pen(Color.Black), points[2].getX(), points[2].getY(), points[3].getX(), points[3].getY());
            e.Graphics.DrawLine(new Pen(Color.Black), points[3].getX(), points[3].getY(), points[0].getX(), points[0].getY());

        }

        public Point[] checkPointsForRectangle(Point[] _point) {

            Point[] point = new Point[N];

            if (!(findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[0], _point[1]))       //0->1->2->3
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[1], _point[2]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[2], _point[3]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[0]))))
            {

                point[0] = _point[0];
                point[1] = _point[1];
                point[2] = _point[2];
                point[3] = _point[3];

            }

            if (!(findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[0], _point[1]))       //0->1->3->2
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[1], _point[3]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[2]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[2], _point[0]))))
            {

                point[0] = _point[0];
                point[1] = _point[1];
                point[2] = _point[3];
                point[3] = _point[2];

            }

            if (!(findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[0], _point[2]))       //0->2->1->3
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[2], _point[1]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[1], _point[3]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[0]))))
            {

                point[0] = _point[0];
                point[1] = _point[2];
                point[2] = _point[1];
                point[3] = _point[3];

            }

            if (!(findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[0], _point[2]))       //0->2->3->1
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[3]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[1]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[1], _point[0]))))
            {

                point[0] = _point[0];
                point[1] = _point[2];
                point[2] = _point[3];
                point[3] = _point[1];

            }

            if (!(findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[0], _point[3]))       //0->3->1->2
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[1]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[1], _point[2]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[2], _point[0]))))
            {

                point[0] = _point[0];
                point[1] = _point[3];
                point[2] = _point[1];
                point[3] = _point[2];

            }

            if (!(findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[0], _point[3]))       //0->3->2->1
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[3], _point[2]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[2], _point[1]))
                || findCenter(_point[0], _point[1], _point[2], _point[3]).equals(findCenter(_point[1], _point[0]))))
            {

                point[0] = _point[0];
                point[1] = _point[3];
                point[2] = _point[2];
                point[3] = _point[1];

            }

            return point;

        }

    }
}
