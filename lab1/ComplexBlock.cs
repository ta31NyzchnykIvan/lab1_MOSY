namespace lab1.Blocks
{
    public class ComplexBlock : BaseBlock
    {
        private BaseBlock[] blocks;
        public ComplexBlock(params BaseBlock[] b) 
        {
            blocks = b; 
        }

        public override double Calculate(double input)
        {
            double result = input;
            foreach (var block in blocks)
                result = block.Calculate(result);
            return result;
        }
    }
}