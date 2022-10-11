using System;


namespace R5T.F0035
{
    public static class Instances
    {
        public static ILoggingBuilderOperator LoggingBuilderOperator { get; } = F0035.LoggingBuilderOperator.Instance;
        public static IServicesOperator ServicesOperator { get; } = F0035.ServicesOperator.Instance;
    }
}