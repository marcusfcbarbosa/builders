using Builders.Shared.Interfaces;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Builders.Shared.Documents
{
    public class BaseDocument :  IDocument
    {
        [BsonElement]
        public Guid id { get; set; }
    }
}
