using Builders.Shared.Documents;

namespace Builders.Domain.EntranceTestContext.Documents
{
    public class BinaryDocument : BaseDocument
    {
        public long Value { get; private set; }

        public string Left { get; private set; }

        public string Right { get; private set; }
        private BinaryDocument() { }
        public BinaryDocument(long value, string left, string right) 
            : this()
        {
            Value = value;
            Left = left;
            Right = right;
        }



    }
}
