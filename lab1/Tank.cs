using lab1.Blocks;

namespace lab1.Blocks
{
    public class Tank
    {
        private double dt;
        private LimitBlock xlimit = new LimitBlock(0, 100);

        private double k1, k2, k3, k4;

        private double t = 1.0;
        public double T
        {
            get => t;
            set
            {
                if (value == 0) throw new System.Exception("T cant be 0");
                t = value;
            }
        }

        private double state = 0.0;

        public double Y => state;

        private double xin1 = 0;
        private double xin2 = 0;
        private double xin3 = 0;
        private double xout = 0;

        public double Xin1 { get => xin1; set => xin1 = xlimit.Calculate(value); }
        public double Xin2 { get => xin2; set => xin2 = xlimit.Calculate(value); }
        public double Xin3 { get => xin3; set => xin3 = xlimit.Calculate(value); }
        public double Xout { get => xout; set => xout = xlimit.Calculate(value); }

        public Tank(double dt, double T, double K1, double K2, double K3, double K4)
        {
            this.dt = dt > 0 ? dt : 0.1;
            this.T = T > 0 ? T : 1.0;
            this.k1 = K1;
            this.k2 = K2;
            this.k3 = K3;
            this.k4 = K4;
        }

        public void Reset(double initial = 0)
        {
            state = xlimit.Calculate(initial);
        }

        public double Calc()
        {
            double inputSum = k1 * xin1 + k2 * xin2 + k3 * xin3 - k4 * xout;
            double derivative = inputSum / T;
            state += dt * derivative;
            state = xlimit.Calculate(state);
            return state;
        }
    }
}