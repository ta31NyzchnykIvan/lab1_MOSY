namespace lab1.Blocks
{
    public class IntBlock : BaseBlock
    {
        private double state = 0;
        private double dt;
        public IntBlock(double step)
        { 
            dt = step; 
        }

        public override double Calculate(double input)
        {
            state += input * dt;
            return state;
        }
    }
}