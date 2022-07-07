using System;

/*
 * Определяет координаты точки
 * и действия с ними
 */

namespace OAiP_laba
{
    class Point
    {
        //координаты точки
        private float X;
        private float Y;

        public Point()
        {

            X = 0;
            Y = 0;

        }

        public Point(float x, float y)
        {

            X = x;
            Y = y;

        }
        //поменять значения x и y у точки
        public virtual void set(Point[] point) { }
        //установить координату x
        public void setX(float x) { X = x; }
        //установить координату y
        public void setY(float y) { Y = y; }
        //получить x 
        public float getX() { return X; }
        //получить y
        public float getY() { return Y; }
        //передвинуть точку по x или y на дельту
        public void moveX(float delta) { X += delta; }
        public void moveY(float delta) { Y += delta; }
        //найти растояние между точками
        public float distanceBetween(Point p1, Point p2) { return sqrt(pow(p2.getX() - p1.getX(), 2) + pow(p2.getY() - p2.getY(), 2)); }
        private float sqrt(float num) { return (float)Math.Sqrt(num); }
        private float pow(float num, int power)
        {

            if (power >= 1)
            {

                for (int i = power; i > 1; i --) { num *= num; }

                return num;

            }

            return 1;

        }
        //найти центр между 2/3/4-мя точками
        public Point findCenter(Point p1, Point p2) { return new Point((p1.getX() + p2.getX()) / 2, (p1.getY() + p2.getY()) / 2); }
        public Point findCenter(Point p1, Point p2, Point p3) { return new Point((p1.getX() + p2.getX() + p3.getX()) / 3, (p1.getY() + p2.getY() + p3.getY()) / 3); }
        public Point findCenter(Point p1, Point p2, Point p3, Point p4) { return new Point((p1.getX() + p2.getX() + p3.getX() + p4.getX()) / 4, (p1.getY() + p2.getY() + p3.getY() + p4.getY()) / 4); }
        //сравнение точек
        public bool equals(Point p) { return Math.Abs(X - p.getX()) <= 0.1 && Math.Abs(Y - p.getY()) <= 0.1; }
    }
}
