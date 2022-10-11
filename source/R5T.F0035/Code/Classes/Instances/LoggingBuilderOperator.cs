using System;


namespace R5T.F0035
{
	public class LoggingBuilderOperator : ILoggingBuilderOperator
	{
		#region Infrastructure

	    public static ILoggingBuilderOperator Instance { get; } = new LoggingBuilderOperator();

	    private LoggingBuilderOperator()
	    {
        }

	    #endregion
	}
}