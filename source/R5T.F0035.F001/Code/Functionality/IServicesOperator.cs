using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.F0035.F001
{
    [FunctionalityMarker]
    public partial interface IServicesOperator : IFunctionalityMarker
    {
        public ILogger GetLogger(IServiceProvider serviceProvider, string categoryName)
        {
            var loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();

            var logger = loggerFactory.CreateLogger(categoryName);
            return logger;
        }

        public ILogger GetLogger<T>(IServiceProvider serviceProvider)
        {
            var logger = serviceProvider.GetRequiredService<ILogger<T>>();
            return logger;
        }
    }
}
