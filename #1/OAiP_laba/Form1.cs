using System;
using System.Windows.Forms;

namespace OAiP_laba
{

    enum figure
    {

        empty = -1,
        Circle,
        Triangle,
        Rectangle,
        lenght

    }
    public partial class Form1 : Form
    {

        List figures1;

        bool isMoving = false;

        public Form1()
        {

            InitializeComponent();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Form1.ActiveForm.Text = "Form 1";

            if (!isMoving && listBox1.Items.Count > 0 && listBox1.SelectedIndex >= 0)
            {

                figure f;

                if (listBox1.SelectedItem.ToString().Equals("Circle")) { f = figure.Circle; }
                else { if (listBox1.SelectedItem.ToString().Equals("Triangle")) { f = figure.Triangle; }
                    else { if (listBox1.SelectedItem.ToString().Equals("Rectangle")) { f = figure.Rectangle; }
                        else { f = figure.empty; } } }

                switch (f)
                {

                    case figure.Circle:

                        if (!Visible_box.Checked)
                        {

                            x2.Enabled = false;
                            y2.Enabled = false;
                            x3.Enabled = false;
                            y3.Enabled = false;
                            x4.Enabled = false;
                            y4.Enabled = false;

                            x1.Enabled = true;
                            y1.Enabled = true;
                            r.Enabled = true;
                            Visible_box.Enabled = true;

                            n_x1.Enabled = false;
                            n_y1.Enabled = false;
                            n_x2.Enabled = false;
                            n_y2.Enabled = false;
                            n_x3.Enabled = false;
                            n_y3.Enabled = false;
                            n_x4.Enabled = false;
                            n_y4.Enabled = false;

                            moveTo.Enabled = false;


                        }
                        else
                        {

                            x1.Enabled = false;
                            y1.Enabled = false;
                            r.Enabled = false;
                            x2.Enabled = false;
                            y2.Enabled = false;
                            x3.Enabled = false;
                            y3.Enabled = false;
                            x4.Enabled = false;
                            y4.Enabled = false;
                            Visible_box.Enabled = true;

                            n_x1.Enabled = true;
                            n_y1.Enabled = true;
                            n_x2.Enabled = false;
                            n_y2.Enabled = false;
                            n_x3.Enabled = false;
                            n_y3.Enabled = false;
                            n_x4.Enabled = false;
                            n_y4.Enabled = false;

                            moveTo.Enabled = true;

                        }

                        break;

                    case figure.Triangle:

                        if (!Visible_box.Checked)
                        {

                            r.Enabled = false;
                            x4.Enabled = false;
                            y4.Enabled = false;

                            x1.Enabled = true;
                            y1.Enabled = true;
                            x2.Enabled = true;
                            y2.Enabled = true;
                            x3.Enabled = true;
                            y3.Enabled = true;
                            Visible_box.Enabled = true;

                            n_x1.Enabled = false;
                            n_y1.Enabled = false;
                            n_x2.Enabled = false;
                            n_y2.Enabled = false;
                            n_x3.Enabled = false;
                            n_y3.Enabled = false;
                            n_x4.Enabled = false;
                            n_y4.Enabled = false;

                            moveTo.Enabled = false;

                        }
                        else
                        {

                            x1.Enabled = false;
                            y1.Enabled = false;
                            r.Enabled = false;
                            x2.Enabled = false;
                            y2.Enabled = false;
                            x3.Enabled = false;
                            y3.Enabled = false;
                            x4.Enabled = false;
                            y4.Enabled = false;
                            Visible_box.Enabled = true;

                            n_x1.Enabled = true;
                            n_y1.Enabled = true;
                            n_x2.Enabled = true;
                            n_y2.Enabled = true;
                            n_x3.Enabled = true;
                            n_y3.Enabled = true;
                            n_x4.Enabled = false;
                            n_y4.Enabled = false;

                            moveTo.Enabled = true;

                        }

                            break;

                    case figure.Rectangle:

                        if (!Visible_box.Checked)
                        {

                            r.Enabled = false;

                            x1.Enabled = true;
                            y1.Enabled = true;
                            x2.Enabled = true;
                            y2.Enabled = true;
                            x3.Enabled = true;
                            y3.Enabled = true;
                            x4.Enabled = true;
                            y4.Enabled = true;
                            Visible_box.Enabled = true;

                            n_x1.Enabled = false;
                            n_y1.Enabled = false;
                            n_x2.Enabled = false;
                            n_y2.Enabled = false;
                            n_x3.Enabled = false;
                            n_y3.Enabled = false;
                            n_x4.Enabled = false;
                            n_y4.Enabled = false;

                            moveTo.Enabled = false;

                        }
                        else
                        {

                            x1.Enabled = false;
                            y1.Enabled = false;
                            r.Enabled = false;
                            x2.Enabled = false;
                            y2.Enabled = false;
                            x3.Enabled = false;
                            y3.Enabled = false;
                            x4.Enabled = false;
                            y4.Enabled = false;
                            Visible_box.Enabled = true;

                            n_x1.Enabled = true;
                            n_y1.Enabled = true;
                            n_x2.Enabled = true;
                            n_y2.Enabled = true;
                            n_x3.Enabled = true;
                            n_y3.Enabled = true;
                            n_x4.Enabled = true;
                            n_y4.Enabled = true;

                            moveTo.Enabled = true;

                        }

                        break;

                    default:

                        x1.Enabled = false;
                        y1.Enabled = false;
                        r.Enabled = false;
                        x2.Enabled = false;
                        y2.Enabled = false;
                        x3.Enabled = false;
                        y3.Enabled = false;
                        x4.Enabled = false;
                        y4.Enabled = false;
                        Visible_box.Enabled = false;
                        n_x1.Enabled = false;
                            n_y1.Enabled = false;
                            n_x2.Enabled = false;
                            n_y2.Enabled = false;
                            n_x3.Enabled = false;
                            n_y3.Enabled = false;
                            n_x4.Enabled = false;
                            n_y4.Enabled = false;
                            moveTo.Enabled = false;
                        break;

                }
            }
            else
            {

                x1.Enabled = false;
                y1.Enabled = false;
                r.Enabled = false;
                x2.Enabled = false;
                y2.Enabled = false;
                x3.Enabled = false;
                y3.Enabled = false;
                x4.Enabled = false;
                y4.Enabled = false;
                Visible_box.Enabled = false;

            }

            paint.Refresh();

        }

        

        private void paint_Paint(object sender, PaintEventArgs e)
        {

            if (listBox1.Items.Count > 0)
            {

                for (int i = 0; i < figures1.getLast().getCount() + 1; i++)
                {

                    switch (figures1.at(i).getFigure().Type)
                    {

                        case "Circle":

                            if(figures1.at(i).getFigure().Visible)
                                (figures1.at(i).getFigure() as Circle).show(e);

                            break;

                        case "Triangle":

                            if (figures1.at(i).getFigure().Visible)
                                (figures1.at(i).getFigure() as Triangle).show(e);

                            break;

                        case "Rectangle":

                            if (figures1.at(i).getFigure().Visible)
                                (figures1.at(i).getFigure() as Rectangle).show(e);

                            break;

                    }

                }

            }

        }

        private void add_Click(object sender, EventArgs e)
        {

            switch (listBox.SelectedIndex)
            {

                case (int)figure.Circle:

                    if (figures1 == null) figures1 = new List(new Circle());
                    else figures1.add(new Circle()); 

                    listBox1.Items.Add("Circle");

                    break;

                case (int)figure.Triangle:

                    if (figures1 == null) figures1 = new List(new Triangle());
                    else figures1.add(new Triangle());

                    listBox1.Items.Add("Triangle");

                    break;

                case (int)figure.Rectangle:

                    if (figures1 == null) figures1 = new List(new Rectangle());
                    else figures1.add(new Rectangle());

                    listBox1.Items.Add("Rectangle");

                    break;
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {

            if(listBox1.SelectedIndex >= 0)
            {

                figures1.delete(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {

                switch (figures1.at(listBox1.SelectedIndex).getFigure().Type)
                {

                    case "Circle":

                        x1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getX();
                        y1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getY();
                        r.Text = "" + (figures1.at(listBox1.SelectedIndex).getFigure() as Circle).getR();
                        x2.Text = "";
                        y2.Text = "";
                        x3.Text = "";
                        y3.Text = "";
                        x4.Text = "";
                        y4.Text = "";
                        Visible_box.Checked = figures1.at(listBox1.SelectedIndex).getFigure().Visible;

                        break;

                    case "Triangle":

                        x1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getX();
                        y1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getY();
                        r.Text = "";
                        x2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getX();
                        y2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getY();
                        x3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getX();
                        y3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getY();
                        x4.Text = "";
                        y4.Text = "";
                        Visible_box.Checked = figures1.at(listBox1.SelectedIndex).getFigure().Visible;

                        break;

                    case "Rectangle":

                        x1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getX();
                        y1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getY();
                        r.Text = "";
                        x2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getX();
                        y2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getY();
                        x3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getX();
                        y3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getY();
                        x4.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].getX();
                        y4.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].getY();
                        Visible_box.Checked = figures1.at(listBox1.SelectedIndex).getFigure().Visible;

                        break;

                }
            }
        }

        private void Visible_box_CheckedChanged(object sender, EventArgs e)
        {

            x1.Text = check(x1.Text);
            y1.Text = check(y1.Text);
            x2.Text = check(x2.Text);
            y2.Text = check(y2.Text);
            x3.Text = check(x3.Text);
            y3.Text = check(y3.Text);
            x4.Text = check(x4.Text);
            y4.Text = check(y4.Text);
            r.Text = check(r.Text);

            switch (figures1.at(listBox1.SelectedIndex).getFigure().Type)
            {

                case "Circle":

                    if (x1.Text.Equals("")) x1.Text = "0";
                    if (y1.Text.Equals("")) y1.Text = "0";
                    if (r.Text.Equals("")) r.Text = "50";

                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setX(Convert.ToSingle(x1.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setY(Convert.ToSingle(y1.Text));
                    (figures1.at(listBox1.SelectedIndex).getFigure() as Circle).setR(Convert.ToSingle(r.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().Visible = Visible_box.Checked;

                    break;

                case "Triangle":

                    if (x1.Text.Equals("")) x1.Text = "0";
                    if (y1.Text.Equals("")) y1.Text = "0";
                    if (x2.Text.Equals("")) x2.Text = "50";
                    if (y2.Text.Equals("")) y2.Text = "0";
                    if (x3.Text.Equals("")) x3.Text = "0";
                    if (y3.Text.Equals("")) y3.Text = "50";

                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setX(Convert.ToSingle(x1.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setY(Convert.ToSingle(y1.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setX(Convert.ToSingle(x2.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setY(Convert.ToSingle(y2.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setX(Convert.ToSingle(x3.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setY(Convert.ToSingle(y3.Text));
                    figures1.at(listBox1.SelectedIndex).getFigure().Visible = Visible_box.Checked;

                    break;

                case "Rectangle":

                    if (x1.Text.Equals("")) x1.Text = "0";
                    if (y1.Text.Equals("")) y1.Text = "0";
                    if (x2.Text.Equals("")) x2.Text = "50";
                    if (y2.Text.Equals("")) y2.Text = "0";
                    if (x3.Text.Equals("")) x3.Text = "50";
                    if (y3.Text.Equals("")) y3.Text = "50";
                    if (x4.Text.Equals("")) x4.Text = "0";
                    if (y4.Text.Equals("")) y4.Text = "50";

                    Point[] points = new Point[4];

                    points[0] = new Point(Convert.ToSingle(x1.Text), Convert.ToSingle(y1.Text));
                    points[1] = new Point(Convert.ToSingle(x2.Text), Convert.ToSingle(y2.Text));
                    points[2] = new Point(Convert.ToSingle(x3.Text), Convert.ToSingle(y3.Text));
                    points[3] = new Point(Convert.ToSingle(x4.Text), Convert.ToSingle(y4.Text));

                    points = (figures1.at(listBox1.SelectedIndex).getFigure() as Rectangle).checkPointsForRectangle(points);

                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setX(points[0].getX());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setY(points[0].getY());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setX(points[1].getX());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setY(points[1].getY());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setX(points[2].getX());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setY(points[2].getY());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].setX(points[3].getX());
                    figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].setY(points[3].getY());
                    figures1.at(listBox1.SelectedIndex).getFigure().Visible = Visible_box.Checked;

                    break;

            }

        }

        private string check(string text)
        {

            string checkedText = "";

            for (int i = 0; i < text.Length; i ++)
            {

                if (Char.IsDigit(text[i]) || ','.Equals(text[i])) checkedText += text[i];

            }

            return checkedText;

        }

        private void moveTo_Click(object sender, EventArgs e)
        {

            timer1.Enabled = false;

            n_x1.Enabled = false;
            n_y1.Enabled = false;
            r.Enabled = false;
            n_x2.Enabled = false;
            n_y2.Enabled = false;
            n_x3.Enabled = false;
            n_y3.Enabled = false;
            n_x4.Enabled = false;
            n_y4.Enabled = false;
            Visible_box.Enabled = false;

            n_x1.Enabled = false;
            n_y1.Enabled = false;
            n_x2.Enabled = false;
            n_y2.Enabled = false;
            n_x3.Enabled = false;
            n_y3.Enabled = false;
            n_x4.Enabled = false;
            n_y4.Enabled = false;

            add.Enabled = false;
            delete.Enabled = false;
            moveTo.Enabled = false;

            listBox.Enabled = false;
            listBox1.Enabled = false;

            Form1.ActiveForm.Text = "while figure moving, you can't doing something";

            n_x1.Text = check(n_x1.Text);
            n_y1.Text = check(n_y1.Text);
            n_x2.Text = check(n_x2.Text);
            n_y2.Text = check(n_y2.Text);
            n_x3.Text = check(n_x3.Text);
            n_y3.Text = check(n_y3.Text);
            n_x4.Text = check(n_x4.Text);
            n_y4.Text = check(n_y4.Text);

            Point[] point;

            switch (figures1.at(listBox1.SelectedIndex).getFigure().Type)
            {

                case "Circle":

                    if (n_x1.Text.Equals("")) n_x1.Text = "0";
                    if (n_y1.Text.Equals("")) n_y1.Text = "0";

                    point = new Point[1];

                    point[0] = new Point(Convert.ToSingle(n_x1.Text), Convert.ToSingle(n_y1.Text));

                    figures1.at(listBox1.SelectedIndex).getFigure().changeSpeed(point);

                    if (figures1.at(listBox1.SelectedIndex).getFigure().checkSpeed()) timer2.Enabled = true;
                    else timer1.Enabled = true;

                    break;

                case "Triangle":

                    if (n_x1.Text.Equals("")) n_x1.Text = "0";
                    if (n_y1.Text.Equals("")) n_y1.Text = "0";
                    if (n_x2.Text.Equals("")) n_x2.Text = "50";
                    if (n_y2.Text.Equals("")) n_y2.Text = "0";
                    if (n_x3.Text.Equals("")) n_x3.Text = "0";
                    if (n_y3.Text.Equals("")) n_y3.Text = "50";

                    point = new Point[3];

                    point[0] = new Point(Convert.ToSingle(n_x1.Text), Convert.ToSingle(n_y1.Text));
                    point[1] = new Point(Convert.ToSingle(n_x2.Text), Convert.ToSingle(n_y2.Text));
                    point[2] = new Point(Convert.ToSingle(n_x3.Text), Convert.ToSingle(n_y3.Text));

                    figures1.at(listBox1.SelectedIndex).getFigure().changeSpeed(point);

                    if (figures1.at(listBox1.SelectedIndex).getFigure().checkSpeed()) timer2.Enabled = true;
                    else timer1.Enabled = true;

                    break;

                case "Rectangle":

                    if (n_x1.Text.Equals("")) n_x1.Text = "0";
                    if (n_y1.Text.Equals("")) n_y1.Text = "0";
                    if (n_x2.Text.Equals("")) n_x2.Text = "50";
                    if (n_y2.Text.Equals("")) n_y2.Text = "0";
                    if (n_x3.Text.Equals("")) n_x3.Text = "50";
                    if (n_y3.Text.Equals("")) n_y3.Text = "50";
                    if (n_x4.Text.Equals("")) n_x4.Text = "0";
                    if (n_y4.Text.Equals("")) n_y4.Text = "50";

                    point = new Point[4];

                    point[0] = new Point(Convert.ToSingle(n_x1.Text), Convert.ToSingle(n_y1.Text));
                    point[1] = new Point(Convert.ToSingle(n_x2.Text), Convert.ToSingle(n_y2.Text));
                    point[2] = new Point(Convert.ToSingle(n_x3.Text), Convert.ToSingle(n_y3.Text));
                    point[3] = new Point(Convert.ToSingle(n_x4.Text), Convert.ToSingle(n_y4.Text));

                    point = (figures1.at(listBox1.SelectedIndex).getFigure() as Rectangle).checkPointsForRectangle(point);

                    figures1.at(listBox1.SelectedIndex).getFigure().changeSpeed(point);

                    if (figures1.at(listBox1.SelectedIndex).getFigure().checkSpeed()) timer2.Enabled = true;
                    else timer1.Enabled = true;

                    break;

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            Point[] point;

            switch (figures1.at(listBox1.SelectedIndex).getFigure().Type)
            {

                case "Circle":

                    point = new Point[1];

                    point[0] = new Point(Convert.ToSingle(n_x1.Text), Convert.ToSingle(n_y1.Text));

                    x1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getX();
                    y1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getY();
                    r.Text = "" + (figures1.at(listBox1.SelectedIndex).getFigure() as Circle).getR();
                    x2.Text = "";
                    y2.Text = "";
                    x3.Text = "";
                    y3.Text = "";
                    x4.Text = "";
                    y4.Text = "";
                    Visible_box.Checked = figures1.at(listBox1.SelectedIndex).getFigure().Visible;

                    break;

                case "Triangle":

                    point = new Point[3];

                    point[0] = new Point(Convert.ToSingle(n_x1.Text), Convert.ToSingle(n_y1.Text));
                    point[1] = new Point(Convert.ToSingle(n_x2.Text), Convert.ToSingle(n_y2.Text));
                    point[2] = new Point(Convert.ToSingle(n_x3.Text), Convert.ToSingle(n_y3.Text));

                    x1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getX();
                    y1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getY();
                    r.Text = "";
                    x2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getX();
                    y2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getY();
                    x3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getX();
                    y3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getY();
                    x4.Text = "";
                    y4.Text = "";
                    Visible_box.Checked = figures1.at(listBox1.SelectedIndex).getFigure().Visible;

                    break;

                case "Rectangle":

                    point = new Point[4];

                    point[0] = new Point(Convert.ToSingle(n_x1.Text), Convert.ToSingle(n_y1.Text));
                    point[1] = new Point(Convert.ToSingle(n_x2.Text), Convert.ToSingle(n_y2.Text));
                    point[2] = new Point(Convert.ToSingle(n_x3.Text), Convert.ToSingle(n_y3.Text));
                    point[3] = new Point(Convert.ToSingle(n_x4.Text), Convert.ToSingle(n_y4.Text));

                    point = (figures1.at(listBox1.SelectedIndex).getFigure() as Rectangle).checkPointsForRectangle(point);

                    x1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getX();
                    y1.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].getY();
                    r.Text = "";
                    x2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getX();
                    y2.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].getY();
                    x3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getX();
                    y3.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].getY();
                    x4.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].getX();
                    y4.Text = "" + figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].getY();
                    Visible_box.Checked = figures1.at(listBox1.SelectedIndex).getFigure().Visible;

                    break;

                default:

                    point = new Point[4];

                    for (int i = 0; i < 4; i++) { point[i] = new Point(); }

                    break;

            }

            if (!figures1.at(listBox1.SelectedIndex).getFigure().moveTo(point))
            {

                checkBox2.Checked = !checkBox2.Checked;

                switch (figures1.at(listBox1.SelectedIndex).getFigure().Type)
                {

                    case "Circle":

                        x1.Text = n_x1.Text;
                        y1.Text = n_y1.Text;

                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setX(Convert.ToSingle(x1.Text));
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setY(Convert.ToSingle(y1.Text));

                        break;

                    case "Triangle":

                        x1.Text = n_x1.Text;
                        y1.Text = n_y1.Text;
                        x2.Text = n_x2.Text;
                        y2.Text = n_y2.Text;
                        x3.Text = n_x3.Text;
                        y3.Text = n_y3.Text;

                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setX(Convert.ToSingle(x1.Text));
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setY(Convert.ToSingle(y1.Text));
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setX(Convert.ToSingle(x2.Text));
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setY(Convert.ToSingle(y2.Text));
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setX(Convert.ToSingle(x3.Text));
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setY(Convert.ToSingle(y3.Text));

                        break;

                    case "Rectangle":

                        x1.Text = n_x1.Text;
                        y1.Text = n_y1.Text;
                        x2.Text = n_x2.Text;
                        y2.Text = n_y2.Text;
                        x3.Text = n_x3.Text;
                        y3.Text = n_y3.Text;
                        x4.Text = n_x4.Text;
                        y4.Text = n_y4.Text;

                        Point[] points = new Point[4];

                        points[0] = new Point(Convert.ToSingle(x1.Text), Convert.ToSingle(y1.Text));
                        points[1] = new Point(Convert.ToSingle(x2.Text), Convert.ToSingle(y2.Text));
                        points[2] = new Point(Convert.ToSingle(x3.Text), Convert.ToSingle(y3.Text));
                        points[3] = new Point(Convert.ToSingle(x4.Text), Convert.ToSingle(y4.Text));

                        points = (figures1.at(listBox1.SelectedIndex).getFigure() as Rectangle).checkPointsForRectangle(points);

                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setX(points[0].getX());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[0].setY(points[0].getY());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setX(points[1].getX());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[1].setY(points[1].getY());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setX(points[2].getX());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[2].setY(points[2].getY());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].setX(points[3].getX());
                        figures1.at(listBox1.SelectedIndex).getFigure().getPoints()[3].setY(points[3].getY());

                        break;

                }

                Form1.ActiveForm.Text = "Form 1";
                timer2.Enabled = false;
                timer1.Enabled = true;

                add.Enabled = true;
                delete.Enabled = true;
                moveTo.Enabled = true;

                listBox.Enabled = true;
                listBox1.Enabled = true;

            }
            else {
                checkBox1.Checked = !checkBox1.Checked;
            }

            paint.Refresh();

        }

    }
}
