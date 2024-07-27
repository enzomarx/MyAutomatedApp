using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace MyAutomatedAppService
{
    public class Service1 : BackgroundService
    {
        private readonly ILogger<Service1> _logger;

        public Service1(ILogger<Service1> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Service running.");
            
            // Example work
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Working...");
                await Task.Delay(10000, stoppingToken); // Wait 10 seconds
            }
        }
    }
}
