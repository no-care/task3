using System.Drawing;
using System.Windows.Forms;

namespace Laba_1
{
    class circle
    {

        private float x;
        private float y;

        private float r;

        private float speedX;
        private float speedY;

        const int TIME = 120;

        public circle()
        {

            x = 0;
            y = 0;
            r = 50;

        }
        public circle(float _x, float _y, float _r)
        {

            x = _x;
            y = _y;
            r = _r;

        }

        public void setX(float _x) { x = _x; }
        public void setY(float _y) { y = _y; }

        public float getX() { return x; }
        public float getY() { return y; }

        public void setR(float _r) { r = _r; }
        public float getR() { return r; }

        public void show(PaintEventArgs paint)
        {

            paint.Graphics.DrawEllipse(new Pen(Color.Red), x - r / 2, y - r / 2, r, r);

        }

        public void changeSpeed(float newX, float newY)
        {

            speedX = (newX - x) / TIME;
            speedY = (newY - y) / TIME;

        }
        public bool moveTo(double newX, double newY)
        {

            bool isWork = false;

            if (x < newX && speedX > 0 || x > newX && speedX < 0)
            {
                x += speedX;
                isWork = true;
            }
            if (y < newY && speedY > 0 || y > newY && speedY < 0)
            {
                y += speedY;
                isWork = true;
            }

            return isWork;

        }

    }
}
