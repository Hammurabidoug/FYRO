using Fyro.Data.Abstractions;
using FYRO.Business.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fyro.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DufferController : ControllerBase
    {
        private readonly ILogger<DufferController> logger;
        private readonly IFyroRepository repository;

        public DufferController(IFyroRepository repository, ILogger<DufferController> logger)
        {
            this.logger = logger;
            this.repository = repository;
        }

        [HttpGet]
        public Task<IEnumerable<Duffer>> GetAsync()
        {
            return repository.GetDuffersAsync();
        }

        [HttpPost]
        public Task<Duffer> AddAsync(Duffer duffer)
        {
            return repository.AddDufferAsync(duffer);
        }
    }
}
