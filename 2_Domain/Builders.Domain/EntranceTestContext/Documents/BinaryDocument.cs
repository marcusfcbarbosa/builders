using Builders.Domain.EntranceTestContext.ValueObjects;
using Builders.Shared.Documents;
using System.Collections.Generic;

namespace Builders.Domain.EntranceTestContext.Documents
{
    public class BinaryDocument : BaseDocument
    {       
       
        public IEnumerable<Tree> three { get; private set; }
        private BinaryDocument() {

        }

        public BinaryDocument(IEnumerable<Tree> three)
            :this()
        {
            this.three = three;
        }
    }

   
}
