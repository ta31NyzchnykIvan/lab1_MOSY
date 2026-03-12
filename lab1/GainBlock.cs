namespace lab1.Blocks
{
    public class GainBlock : BaseBlock
    {
        private double gain;
        public GainBlock(double g)
        {
            gain = g; 
        }
        public override double Calculate(double input) => input * gain;
    }
}