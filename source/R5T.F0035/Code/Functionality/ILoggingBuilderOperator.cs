using System;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.F0035
{
	[FunctionalityMarker]
	public partial interface ILoggingBuilderOperator : IFunctionalityMarker
	{
		public void AddLogging(ILoggingBuilder loggingBuilder)
		{
			loggingBuilder
				.SetMinimumLevel(LogLevel.Debug)
				.AddConsole()
				;
		}
	}
}