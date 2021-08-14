using Builders.Domain.EntranceTestContext.Documents;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Infra.Context;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Builders.Infra.Repositories
{
    public class BinaryRepository : IBinaryRepository
    {

        private readonly BuildersContext _buildersContext;
        public BinaryRepository(IOptions<ConfigDB> options)
        {
            _buildersContext = new BuildersContext(options);
        }
        public async Task CreateAsync(BinaryDocument document)
        {
            document.id = Guid.NewGuid();
            await _buildersContext.Binaries.InsertOneAsync(document);
        }

        public async Task<IEnumerable<BinaryDocument>> GetAll()
        {
            return await _buildersContext.Binaries.Find(_ => true).ToListAsync();
        }

        public async Task<BinaryDocument> GetById(Guid id)
        {
            return await _buildersContext.Binaries.Find(_ => true && _.id== id).FirstOrDefaultAsync();
        }
    }
}
