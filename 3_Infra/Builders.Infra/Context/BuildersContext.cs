using Builders.Infra.Context.Documents;
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



        public IMongoCollection<Palindrome> Palindromes
        {
            get
            {
                return _mongoDatabase.GetCollection<Palindrome>("Palindrome");
            }
        }

        public IMongoCollection<Binary> Binaries
        {
            get
            {
                return _mongoDatabase.GetCollection<Binary>("Binaries");
            }
        }
    }
}
