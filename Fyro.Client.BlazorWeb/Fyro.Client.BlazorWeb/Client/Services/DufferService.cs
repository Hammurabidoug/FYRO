using FYRO.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Fyro.Web.Blazor.Client.Services
{
    public class DufferService
    {
        private readonly HttpClient client;

        public DufferService(HttpClient client)
        {
            this.client = client;
        }

        public Task<IEnumerable<Duffer>> GetDuffersAsync()
        {
            return Task.FromResult(new List<Duffer>().AsEnumerable());
        }
    }
}
