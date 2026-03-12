using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab1
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnStart, btnStop, btnX1, btnX10;
        private Button btnXin1Plus;
        private Button btnXin2Plus;
        private Button btnXin3Plus;
        private Button btnXoutPlus;
        private Button btnXin1Minus;
        private Button btnXin2Minus;
        private Button btnXin3Minus;
        private Button btnXoutMinus;
        private Timer timer1;
        private Label lblZ1;
        private Chart chart1;
        private PictureBox pictureBox1;
        private Label lblXin1;
        private Label lblXin2;
        private Label lblXin3;
        private Label lblXout;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.btnXin1Plus = new System.Windows.Forms.Button();
            this.btnXin1Minus = new System.Windows.Forms.Button();
            this.btnXin2Plus = new System.Windows.Forms.Button();
            this.btnXin2Minus = new System.Windows.Forms.Button();
            this.btnXin3Plus = new System.Windows.Forms.Button();
            this.btnXin3Minus = new System.Windows.Forms.Button();
            this.btnXoutPlus = new System.Windows.Forms.Button();
            this.btnXoutMinus = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblZ1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblXin1 = new System.Windows.Forms.Label();
            this.lblXin2 = new System.Windows.Forms.Label();
            this.lblXin3 = new System.Windows.Forms.Label();
            this.lblXout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(100, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnX1
            // 
            this.btnX1.Location = new System.Drawing.Point(180, 20);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(75, 23);
            this.btnX1.TabIndex = 2;
            this.btnX1.Text = "X1";
            this.btnX1.Click += new System.EventHandler(this.btnX1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Location = new System.Drawing.Point(240, 20);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(75, 23);
            this.btnX10.TabIndex = 3;
            this.btnX10.Text = "X10";
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            this.btnXin1Plus.Location = new Point(20, 60);
            this.btnXin1Plus.Text = "Xin1 +";
            this.btnXin1Plus.Click += new EventHandler(this.btnXin1Plus_Click);
            this.btnXin1Plus.Visible = false;

            this.btnXin1Minus.Location = new Point(100, 60);
            this.btnXin1Minus.Text = "Xin1 -";
            this.btnXin1Minus.Click += new EventHandler(this.btnXin1Minus_Click);
            this.btnXin1Minus.Visible = false;

            this.lblXin1.Location = new Point(200, 60);
            this.lblXin1.Size = new Size(100, 23);
            this.lblXin1.Text = "Xin1: 3";

            // Xin2
            this.btnXin2Plus.Location = new Point(20, 90);
            this.btnXin2Plus.Text = "Xin2 +";
            this.btnXin2Plus.Click += new EventHandler(this.btnXin2Plus_Click);

            this.btnXin2Minus.Location = new Point(100, 90);
            this.btnXin2Minus.Text = "Xin2 -";
            this.btnXin2Minus.Click += new EventHandler(this.btnXin2Minus_Click);

            this.lblXin2.Location = new Point(200, 90);
            this.lblXin2.Size = new Size(100, 23);
            this.lblXin2.Text = "Xin2: 0";

            // Xin3
            this.btnXin3Plus.Location = new Point(20, 120);
            this.btnXin3Plus.Text = "Xin3 +";
            this.btnXin3Plus.Click += new EventHandler(this.btnXin3Plus_Click);

            this.btnXin3Minus.Location = new Point(100, 120);
            this.btnXin3Minus.Text = "Xin3 -";
            this.btnXin3Minus.Click += new EventHandler(this.btnXin3Minus_Click);

            this.lblXin3.Location = new Point(200, 120);
            this.lblXin3.Size = new Size(100, 23);
            this.lblXin3.Text = "Xin3: 0";

            // Xout
            this.btnXoutPlus.Location = new Point(20, 150);
            this.btnXoutPlus.Text = "Xout +";
            this.btnXoutPlus.Click += new EventHandler(this.btnXoutPlus_Click);
            this.btnXoutPlus.Visible = false;

            this.btnXoutMinus.Location = new Point(100, 150);
            this.btnXoutMinus.Text = "Xout -";
            this.btnXoutMinus.Click += new EventHandler(this.btnXoutMinus_Click);
            this.btnXoutMinus.Visible = false;

            this.lblXout.Location = new Point(200, 150);
            this.lblXout.Size = new Size(100, 23);
            this.lblXout.Text = "Xout: 15";
            //
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblZ1
            // 
            this.lblZ1.Location = new System.Drawing.Point(20, 220);
            this.lblZ1.Name = "lblZ1";
            this.lblZ1.Size = new System.Drawing.Size(100, 23);
            this.lblZ1.TabIndex = 14;
            this.lblZ1.Text = "Z1: 10.00";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(20, 250);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Z1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 200);
            this.chart1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnXin1Plus);
            this.Controls.Add(this.btnXin1Minus);
            this.Controls.Add(this.lblXin1);
            this.Controls.Add(this.btnXin2Plus);
            this.Controls.Add(this.btnXin2Minus);
            this.Controls.Add(this.lblXin2);
            this.Controls.Add(this.btnXin3Plus);
            this.Controls.Add(this.btnXin3Minus);
            this.Controls.Add(this.lblXin3);
            this.Controls.Add(this.btnXoutPlus);
            this.Controls.Add(this.btnXoutMinus);
            this.Controls.Add(this.lblXout);
            this.Controls.Add(this.lblZ1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "lab1 - Tank Control";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}