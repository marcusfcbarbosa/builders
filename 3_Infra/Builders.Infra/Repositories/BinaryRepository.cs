using Builders.Domain.EntranceTestContext.Documents;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Infra.Context;
using Microsoft.Extensions.Options;
using System;
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
            try {
                document.id = Guid.NewGuid();
                await _buildersContext.Binaries.InsertOneAsync(document);

            } catch (Exception ex) { 
            
                string erro = ex.Message;
            }
            
        }


    }
}
