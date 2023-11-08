using CleanArchitecture.ApplicationCore;
using CleanArchitecture.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.WebUITest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly ILogRepository? _LogRepository;

        public UnitTest1()
        {
            var services = new ServiceCollection();
            services.AddTransient<ILogRepository, LogRepository>();
            var serviceProvider = services.BuildServiceProvider();
            _LogRepository = serviceProvider.GetService<ILogRepository>();
        }

        [TestMethod]
        public async Task TestMethod1()
        {
            var result = await _LogRepository.GetLogsAsync();
            var message = result.First().message;

            Assert.IsTrue(message == "This is a sample log");
        }
    }
}