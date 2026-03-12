namespace lab1.Blocks
{
    public class DiffBlock : BaseBlock
    {
        private double prev = 0;
        private double dt;
        public DiffBlock(double step) 
        { 
            dt = step;
        }

        public override double Calculate(double input)
        {
            double diff = (input - prev) / dt;
            prev = input;
            return diff;
        }
    }
}