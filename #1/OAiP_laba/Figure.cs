/*
 * Определяет все фигуры
 * и действия с ними
 */

using System;
namespace OAiP_laba
{
    abstract class Figure : Point
    {

        protected Point[] points;
         
        protected float[] speedX;
        protected float[] speedY;

        public bool Visible = false;

        public string Type;

        protected const float TIME = 240;
        protected int N;
        //получение кол-во вершин у фигуры
        public int getN() { return N; }
        public Point[] getPoints() { return points; }
        public abstract void show(System.Windows.Forms.PaintEventArgs e);
        //с помощью таймера передвинуть фигуру 
        public bool moveTo(Point[] newPoint)
        {

            bool isWork = false;

            for (int i = 0; i < points.Length; i++)
            {

                if (points[i].getX() < newPoint[i].getX() && speedX[i] > 0 || points[i].getX() > newPoint[i].getX() && speedX[i] < 0) { points[i].moveX(speedX[i]); isWork = true; }
                if (points[i].getY() < newPoint[i].getY() && speedY[i] > 0 || points[i].getY() > newPoint[i].getY() && speedY[i] < 0) { points[i].moveY(speedY[i]); isWork = true; }

            }

            return isWork;

        }
        //расчитать скорость передвижения каждой точки
        public void changeSpeed(Point[] point)
        {

            for (int i = 0; i < points.Length; i++)
            {

                speedX[i] = (point[i].getX() - points[i].getX()) / TIME;
                speedY[i] = (point[i].getY() - points[i].getY()) / TIME;

            }

        }
        //очистить полотно
        public void clean(System.Windows.Forms.PaintEventArgs e) { e.Graphics.Clear(System.Drawing.Color.White); }

        public bool checkSpeed()
        {

            bool isWork = false;

            for (int i = 0; i < N; i++)
            {

                if (!(Math.Abs(speedX[i]) <= 0.01 && Math.Abs(speedX[i]) <= 0.01)) { isWork = true; }

            }

            return isWork;
        }
    }
}
