using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using lab1.Blocks;

namespace lab1
{
    public partial class MainForm : Form
    {
        double Z1 = 0;
        double Xin1 = 3, Xin2 = 0, Xin3 = 0, Xout = 15;
        double dt = 0.1;
        double speed = 1.0;

        Tank tankModel;

        public MainForm()
        {
            InitializeComponent();
            tankModel = new Tank(dt, 1.0, 1.0, 1.0, 1.0, 1.0);
            lblXin1.Text = $"Xin1: {Xin1}";
            lblXout.Text = $"Xout: {Xout}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            speed = 1.0;
        }

        private void btnX10_Click(object sender, EventArgs e)
        {
            speed = 10.0;
        }

        private void btnXin1Plus_Click(object sender, EventArgs e) 
        { 
            // Input 1 is constant; no changes allowed.
        }

        private void btnXin1Minus_Click(object sender, EventArgs e) 
        { 
            // Input 1 is constant; no changes allowed.
        }

        private void btnXin2Plus_Click(object sender, EventArgs e) 
        { 
            Xin2++; lblXin2.Text = $"Xin2: {Xin2}"; 
        }

        private void btnXin2Minus_Click(object sender, EventArgs e) 
        { 
            Xin2--; lblXin2.Text = $"Xin2: {Xin2}"; 
        }

        private void btnXin3Plus_Click(object sender, EventArgs e) 
        { 
            Xin3++; lblXin3.Text = $"Xin3: {Xin3}"; 
        }

        private void btnXin3Minus_Click(object sender, EventArgs e) 
        { 
            Xin3--; lblXin3.Text = $"Xin3: {Xin3}"; 
        }

        private void btnXoutPlus_Click(object sender, EventArgs e) 
        { 
            // Output is constant; no changes allowed.
        }

        private void btnXoutMinus_Click(object sender, EventArgs e) 
        { 
            // Output is constant; no changes allowed.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int steps = Math.Max(1, (int)Math.Round(timer1.Interval / (dt * 1000.0) * speed));
            for (int i = 0; i < steps; i++)
            {
                tankModel.Xin1 = Xin1;
                tankModel.Xin2 = Xin2;
                tankModel.Xin3 = Xin3;
                tankModel.Xout = Xout;
                tankModel.Calc();
            }

            Z1 = tankModel.Y;
            lblZ1.Text = $"Z1: {Z1:F2}";
            chart1.Series["Z1"].Points.AddY(Z1);
        }
    }
}