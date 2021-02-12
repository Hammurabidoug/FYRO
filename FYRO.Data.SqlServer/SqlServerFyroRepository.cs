using AutoMapper;
using Fyro.Data;
using Fyro.Data.Abstractions;
using Fyro.Data.Entities;
using FYRO.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FYRO.Data.SqlServer
{
    internal class SqlServerFyroRepository : IFyroRepository
    {
        private readonly FyroDbContext dbContext;
        private readonly IMapper mapper;

        public SqlServerFyroRepository(FyroDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;

            this.mapper = mapper;
        }

        public async Task<Duffer> AddDufferAsync(Duffer duffer)
        {
            var entity = this.mapper.Map<DufferEntity>(duffer);

            var entry = this.dbContext.Duffers.Add(entity);

            await this.dbContext.SaveChangesAsync();

            return this.mapper.Map<Duffer>(entry.Entity);
        }

        public Task<IEnumerable<Duffer>> GetDuffersAsync()
        {
            return Task.FromResult(this.mapper.Map<IEnumerable<Duffer>>(dbContext.Duffers.ToArray()));
        }
    }
}
