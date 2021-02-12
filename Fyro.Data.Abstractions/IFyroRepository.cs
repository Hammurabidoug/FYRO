using FYRO.Business.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fyro.Data.Abstractions
{
    public interface IFyroRepository
    {
        public Task<IEnumerable<Duffer>> GetDuffersAsync();

        public Task<Duffer> AddDufferAsync(Duffer duffer);
    }
}
