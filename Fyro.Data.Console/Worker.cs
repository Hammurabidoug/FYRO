using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace Fyro.Data.Console
{
    internal class Worker : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            //throw new System.NotImplementedException();

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
            //throw new System.NotImplementedException();
        }
    }
}