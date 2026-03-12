namespace lab1.Blocks
{
    public class DelayBlock : BaseBlock
    {
        private double prev = 0;
        public override double Calculate(double input)
        {
            double output = prev;
            prev = input;
            return output;
        }
    }
}