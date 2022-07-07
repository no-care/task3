using System.Drawing;
using System.Windows.Forms;

/*
 * Определяет окружность
 * и действия с ней
 */

namespace OAiP_laba
{
    class Circle : Figure
    {
        //радиус
        private float r;

        public Circle()
        {

            N = 1;

            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = new Point();

            r = 50;

            Type = "Circle";

        }

        public Circle(Point p, float _r)
        {

            N = 1;

            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = p;

            r = _r;

            Type = "Circle";

        }

        public Circle(float x, float y, float _r)
        {

            N = 1;

            points = new Point[N];
            speedX = new float[N];
            speedY = new float[N];

            points[0] = new Point(x, y);

            r = _r;

            Type = "Circle";

        }
        //устанавливает координаты центра окружности
        public override void set(Point[] _points)
        {
            points[0] = _points[0];
        }
        //устанавливает радиус окружности
        public void setR(float _r) { r = _r; }
        //возращает радиус окружности 
        public float getR() { return r; }
        //отрисовка окружности
        public override void show(PaintEventArgs e) { e.Graphics.DrawEllipse(new Pen(Color.Black), points[0].getX() - r / 2, points[0].getY() - r / 2, r, r); }

    }
}
