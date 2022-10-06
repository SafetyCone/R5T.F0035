using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.F0035
{
	[FunctionalityMarker]
	public partial interface IServicesOperator : IFunctionalityMarker
	{
		public void AddLogging(IServiceCollection services)
		{
			services
				.AddLogging(loggingBuilder =>
				{
					loggingBuilder
						.SetMinimumLevel(LogLevel.Debug)
						.AddConsole()
						;
				})
				;
		}

        public ILogger GetLogger(IServiceProvider serviceProvider, string categoryName)
        {
			var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

			var logger = loggerFactory.CreateLogger(categoryName);
			return logger;
        }
    }
}