using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.F0035
{
	[FunctionalityMarker]
	public partial interface ILoggingOperator : IFunctionalityMarker
	{
		public void InConsoleLoggerContext_Synchronous<T>(
			Action<ILogger> loggerAction)
		{
			var services = new ServiceCollection();

			ServicesOperator.Instance.AddLogging(services);

			using var serviceProvider = services.BuildServiceProvider();

			var logger = ServicesOperator.Instance.GetLogger<T>(serviceProvider);

			loggerAction(logger);
		}

        public async Task InConsoleLoggerContext<T>(
            Func<ILogger, Task> loggerAction)
        {
            var services = new ServiceCollection();

            ServicesOperator.Instance.AddLogging(services);

            using var serviceProvider = services.BuildServiceProvider();

            var logger = ServicesOperator.Instance.GetLogger<T>(serviceProvider);

            await loggerAction(logger);
        }

        public void InConsoleLoggerContext_Synchronous(
            string categoryName,
            Action<ILogger> loggerAction)
        {
            var services = new ServiceCollection();

            ServicesOperator.Instance.AddLogging(services);

            using var serviceProvider = services.BuildServiceProvider();

            var logger = ServicesOperator.Instance.GetLogger(
                serviceProvider,
                categoryName);

            loggerAction(logger);
        }

        public async Task InConsoleLoggerContext(
            string categoryName,
            Func<ILogger, Task> loggerAction)
        {
            var services = new ServiceCollection();

            ServicesOperator.Instance.AddLogging(services);

            using var serviceProvider = services.BuildServiceProvider();

            var logger = ServicesOperator.Instance.GetLogger(
                serviceProvider,
                categoryName);

            await loggerAction(logger);
        }

        public TOutput InConsoleLoggerContext_Synchronous<TOutput>(
           string categoryName,
           Func<ILogger, TOutput> loggerFunction)
        {
            var services = new ServiceCollection();

            ServicesOperator.Instance.AddLogging(services);

            using var serviceProvider = services.BuildServiceProvider();

            var logger = ServicesOperator.Instance.GetLogger(
                serviceProvider,
                categoryName);

            var output = loggerFunction(logger);
            return output;
        }
    }
}