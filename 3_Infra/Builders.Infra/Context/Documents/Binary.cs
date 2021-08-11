namespace Builders.Infra.Context.Documents
{
    public class Binary : BaseDocument
    {
        public long Value { get; private set; }

        public string Left { get; private set; }

        public string Right { get; private set; }
        private Binary() { }
        public Binary(long value, string left, string right) 
            : this()
        {
            Value = value;
            Left = left;
            Right = right;
        }



    }
}
