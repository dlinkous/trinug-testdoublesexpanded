using System;
using System.Linq;
using Xunit;
using SpaceManagement.V05;

namespace SpaceManagement.Tests.Unit.V05
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_LogsMessageBeforeCreation()
		{
			var logger = new LoggerSpy();
			var service = new SpaceManagementService(new SpaceRepositoryDummy(), new TrueSettingsStub(), logger);
			const int location = 999;
			service.CreateSpace(location);
			var logMessage = logger.LogCalls.Single();
			Assert.Equal($"Creating space {location}...", logMessage);
		}
	}
}
