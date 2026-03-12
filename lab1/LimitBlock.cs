namespace lab1.Blocks
{
    public class LimitBlock : BaseBlock
    {
        private double min, max;
        public LimitBlock(double minVal, double maxVal)
        {
            min = minVal; max = maxVal;
        }
        public override double Calculate(double input)
        {
            if (input < min) return min;
            if (input > max) return max;
            return input;
        }
    }
}