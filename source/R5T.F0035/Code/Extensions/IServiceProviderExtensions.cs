using System;

//using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Instances = R5T.F0035.Instances;



namespace System
{
    public static class IServiceProviderExtensions
    {
        public static ILogger GetLogger(this IServiceProvider serviceProvider, string categoryName)
        {
            var logger = Instances.ServicesOperator.GetLogger(serviceProvider, categoryName);
            return logger;
        }

        public static ILogger GetLogger<T>(this IServiceProvider serviceProvider)
        {
            var logger = Instances.ServicesOperator.GetLogger<T>(serviceProvider);
            return logger;
        }
    }
}
