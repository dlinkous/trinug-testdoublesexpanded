using System;
using System.Collections.Generic;

namespace SpaceManagement.Tests.Unit.V05
{
	internal class LoggerSpy : ILogger
	{
		internal List<string> LogCalls { get; private set; } = new List<string>();

		public void Log(string message) => LogCalls.Add(message);
	}
}
