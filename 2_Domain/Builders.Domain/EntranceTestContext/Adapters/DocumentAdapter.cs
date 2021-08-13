using Builders.Domain.EntranceTestContext.Commands.Input;
using Builders.Domain.EntranceTestContext.Documents;
using Builders.Domain.EntranceTestContext.ValueObjects;
using Builders.Shared.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Builders.Domain.EntranceTestContext.Adapters
{
    public static class DocumentAdapter
    {

        public static BinaryDocument CommandToDocument(CriaBinaryCommand command)
        {
            List<Tree> trees = new List<Tree>();
            command.inputs.ForEach(x => trees.Add(new Tree { Left = x.Left, Node = x.node, Right = x.Right, Value = x.Value }));
            return new BinaryDocument(trees);
        }
    }
}
