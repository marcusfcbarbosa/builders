using Builders.Domain.EntranceTestContext.Documents;
using Builders.Domain.EntranceTestContext.Repositories;
using Builders.Infra.Context;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builders.Infra.Repositories
{
    public class PalindromeRepository : IPalindromeRepository
    {
        private readonly BuildersContext _buildersContext;
        public PalindromeRepository(IOptions<ConfigDB> options)
        {
            _buildersContext = new BuildersContext(options);
        }
        public async Task CreateAsync(PalindromeDocument document)
        {
            document.id = Guid.NewGuid();
            await _buildersContext.Palindromes.InsertOneAsync(document);
        }

        public Task<IEnumerable<PalindromeDocument>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
