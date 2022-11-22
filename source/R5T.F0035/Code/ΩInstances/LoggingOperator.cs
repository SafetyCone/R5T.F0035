using System;


namespace R5T.F0035
{
	public class LoggingOperator : ILoggingOperator
	{
		#region Infrastructure

	    public static ILoggingOperator Instance { get; } = new LoggingOperator();

	    private LoggingOperator()
	    {
        }

	    #endregion
	}
}