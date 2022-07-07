namespace OAiP_laba
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paint = new System.Windows.Forms.PictureBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.n_y4 = new System.Windows.Forms.TextBox();
            this.n_y3 = new System.Windows.Forms.TextBox();
            this.n_y2 = new System.Windows.Forms.TextBox();
            this.n_y1 = new System.Windows.Forms.TextBox();
            this.n_x4 = new System.Windows.Forms.TextBox();
            this.n_x3 = new System.Windows.Forms.TextBox();
            this.n_x2 = new System.Windows.Forms.TextBox();
            this.n_x1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.moveTo = new System.Windows.Forms.Button();
            this.Visible_box = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.y4 = new System.Windows.Forms.TextBox();
            this.x4 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.r = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paint)).BeginInit();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paint
            // 
            this.paint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paint.Dock = System.Windows.Forms.DockStyle.Right;
            this.paint.Location = new System.Drawing.Point(164, 0);
            this.paint.Margin = new System.Windows.Forms.Padding(2);
            this.paint.Name = "paint";
            this.paint.Size = new System.Drawing.Size(570, 438);
            this.paint.TabIndex = 0;
            this.paint.TabStop = false;
            this.paint.Paint += new System.Windows.Forms.PaintEventHandler(this.paint_Paint);
            // 
            // listBox
            // 
            this.listBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox.FormattingEnabled = true;
            this.listBox.Items.AddRange(new object[] {
            "Круг",
            "Треугольник",
            "Прямоугольник"});
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(164, 43);
            this.listBox.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.Visible_box);
            this.panel.Controls.Add(this.label9);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.y4);
            this.panel.Controls.Add(this.x4);
            this.panel.Controls.Add(this.y3);
            this.panel.Controls.Add(this.x3);
            this.panel.Controls.Add(this.r);
            this.panel.Controls.Add(this.y2);
            this.panel.Controls.Add(this.x2);
            this.panel.Controls.Add(this.y1);
            this.panel.Controls.Add(this.x1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 116);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(164, 322);
            this.panel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.n_y4);
            this.panel1.Controls.Add(this.n_y3);
            this.panel1.Controls.Add(this.n_y2);
            this.panel1.Controls.Add(this.n_y1);
            this.panel1.Controls.Add(this.n_x4);
            this.panel1.Controls.Add(this.n_x3);
            this.panel1.Controls.Add(this.n_x2);
            this.panel1.Controls.Add(this.n_x1);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.moveTo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 182);
            this.panel1.TabIndex = 21;
            // 
            // n_y4
            // 
            this.n_y4.Location = new System.Drawing.Point(114, 73);
            this.n_y4.Margin = new System.Windows.Forms.Padding(2);
            this.n_y4.Name = "n_y4";
            this.n_y4.Size = new System.Drawing.Size(42, 20);
            this.n_y4.TabIndex = 17;
            // 
            // n_y3
            // 
            this.n_y3.Location = new System.Drawing.Point(114, 50);
            this.n_y3.Margin = new System.Windows.Forms.Padding(2);
            this.n_y3.Name = "n_y3";
            this.n_y3.Size = new System.Drawing.Size(42, 20);
            this.n_y3.TabIndex = 16;
            // 
            // n_y2
            // 
            this.n_y2.Location = new System.Drawing.Point(114, 28);
            this.n_y2.Margin = new System.Windows.Forms.Padding(2);
            this.n_y2.Name = "n_y2";
            this.n_y2.Size = new System.Drawing.Size(42, 20);
            this.n_y2.TabIndex = 15;
            // 
            // n_y1
            // 
            this.n_y1.Location = new System.Drawing.Point(114, 5);
            this.n_y1.Margin = new System.Windows.Forms.Padding(2);
            this.n_y1.Name = "n_y1";
            this.n_y1.Size = new System.Drawing.Size(42, 20);
            this.n_y1.TabIndex = 14;
            // 
            // n_x4
            // 
            this.n_x4.Location = new System.Drawing.Point(31, 73);
            this.n_x4.Margin = new System.Windows.Forms.Padding(2);
            this.n_x4.Name = "n_x4";
            this.n_x4.Size = new System.Drawing.Size(42, 20);
            this.n_x4.TabIndex = 13;
            // 
            // n_x3
            // 
            this.n_x3.Location = new System.Drawing.Point(31, 50);
            this.n_x3.Margin = new System.Windows.Forms.Padding(2);
            this.n_x3.Name = "n_x3";
            this.n_x3.Size = new System.Drawing.Size(42, 20);
            this.n_x3.TabIndex = 12;
            // 
            // n_x2
            // 
            this.n_x2.Location = new System.Drawing.Point(31, 28);
            this.n_x2.Margin = new System.Windows.Forms.Padding(2);
            this.n_x2.Name = "n_x2";
            this.n_x2.Size = new System.Drawing.Size(42, 20);
            this.n_x2.TabIndex = 11;
            // 
            // n_x1
            // 
            this.n_x1.Location = new System.Drawing.Point(31, 5);
            this.n_x1.Margin = new System.Windows.Forms.Padding(2);
            this.n_x1.Name = "n_x1";
            this.n_x1.Size = new System.Drawing.Size(42, 20);
            this.n_x1.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(84, 76);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "y4 =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "x4 =";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(84, 53);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "y3 =";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 53);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "x3 =";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(84, 30);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "y2 =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "x2 =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 8);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "y1 =";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "x1 = ";
            // 
            // moveTo
            // 
            this.moveTo.Location = new System.Drawing.Point(2, 98);
            this.moveTo.Margin = new System.Windows.Forms.Padding(2);
            this.moveTo.Name = "moveTo";
            this.moveTo.Size = new System.Drawing.Size(68, 22);
            this.moveTo.TabIndex = 1;
            this.moveTo.Text = "Move to";
            this.moveTo.UseVisualStyleBackColor = true;
            this.moveTo.Click += new System.EventHandler(this.moveTo_Click);
            // 
            // Visible_box
            // 
            this.Visible_box.AutoSize = true;
            this.Visible_box.Location = new System.Drawing.Point(4, 119);
            this.Visible_box.Margin = new System.Windows.Forms.Padding(2);
            this.Visible_box.Name = "Visible_box";
            this.Visible_box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Visible_box.Size = new System.Drawing.Size(56, 17);
            this.Visible_box.TabIndex = 20;
            this.Visible_box.Text = "Visible";
            this.Visible_box.UseVisualStyleBackColor = true;
            this.Visible_box.CheckedChanged += new System.EventHandler(this.Visible_box_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "y4 =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "y3 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "y2 =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "x4 =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "x3 =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "x2 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "r =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "y1 =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "x1 =";
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(114, 96);
            this.y4.Margin = new System.Windows.Forms.Padding(2);
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(42, 20);
            this.y4.TabIndex = 10;
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(31, 96);
            this.x4.Margin = new System.Windows.Forms.Padding(2);
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(42, 20);
            this.x4.TabIndex = 9;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(114, 73);
            this.y3.Margin = new System.Windows.Forms.Padding(2);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(42, 20);
            this.y3.TabIndex = 8;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(31, 73);
            this.x3.Margin = new System.Windows.Forms.Padding(2);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(42, 20);
            this.x3.TabIndex = 7;
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(31, 28);
            this.r.Margin = new System.Windows.Forms.Padding(2);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(42, 20);
            this.r.TabIndex = 6;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(114, 50);
            this.y2.Margin = new System.Windows.Forms.Padding(2);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(42, 20);
            this.y2.TabIndex = 5;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(31, 50);
            this.x2.Margin = new System.Windows.Forms.Padding(2);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(42, 20);
            this.x2.TabIndex = 4;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(114, 5);
            this.y1.Margin = new System.Windows.Forms.Padding(2);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(42, 20);
            this.y1.TabIndex = 3;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(31, 5);
            this.x1.Margin = new System.Windows.Forms.Padding(2);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(42, 20);
            this.x1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(2, 47);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(68, 22);
            this.add.TabIndex = 21;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 74);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 43);
            this.listBox1.TabIndex = 22;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(84, 47);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 22);
            this.delete.TabIndex = 23;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 438);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.paint);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.paint)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox paint;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button moveTo;
        private System.Windows.Forms.TextBox y4;
        private System.Windows.Forms.TextBox x4;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.CheckBox Visible_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox n_y4;
        private System.Windows.Forms.TextBox n_y3;
        private System.Windows.Forms.TextBox n_y2;
        private System.Windows.Forms.TextBox n_y1;
        private System.Windows.Forms.TextBox n_x4;
        private System.Windows.Forms.TextBox n_x3;
        private System.Windows.Forms.TextBox n_x2;
        private System.Windows.Forms.TextBox n_x1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

