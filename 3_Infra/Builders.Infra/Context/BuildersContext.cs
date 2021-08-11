using Builders.Domain.EntranceTestContext.Documents;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Builders.Infra.Context
{
    public class BuildersContext
    {

        private readonly IMongoDatabase _mongoDatabase;

        public BuildersContext(IOptions<ConfigDB> options)
        {

            MongoClient mongoClient = new MongoClient(options.Value.ConnectionString);
            if (mongoClient != null)
            {
                _mongoDatabase = mongoClient.GetDatabase(options.Value.DataBase);
            }
        }
        public IMongoCollection<PalindromeDocument> Palindromes
        {
            get
            {
                return _mongoDatabase.GetCollection<PalindromeDocument>("Palindrome");
            }
        }

        public IMongoCollection<BinaryDocument> Binaries
        {
            get
            {
                return _mongoDatabase.GetCollection<BinaryDocument>("Binaries");
            }
        }
    }
}
