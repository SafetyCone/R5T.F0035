using System;


namespace R5T.F0035
{
    public static class Instances
    {
        public static ILoggingBuilderOperator LoggingBuilderOperator => F0035.LoggingBuilderOperator.Instance;
        public static IServicesOperator ServicesOperator => F0035.ServicesOperator.Instance;
    }
}