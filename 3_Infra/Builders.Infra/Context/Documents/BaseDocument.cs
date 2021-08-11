using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Builders.Infra.Context.Documents
{
    public class BaseDocument
    {
        [BsonElement]
        public Guid id { get; set; }
    }
}
