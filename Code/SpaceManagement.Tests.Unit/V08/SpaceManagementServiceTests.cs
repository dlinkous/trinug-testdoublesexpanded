using System;
using Xunit;
using SpaceManagement.V08;

namespace SpaceManagement.Tests.Unit.V08
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_CreatesSpaceCorrectly()
		{
			var repository = new SpaceRepositoryFake();
			var service = new SpaceManagementService(repository, new TrueSettingsStub(), new LoggerStub());
			const int location = 999;
			service.CreateSpace(location);
			var space = repository.Read(location);
			Assert.NotNull(space);
			Assert.Equal(location, space.Location);
			Assert.Equal(string.Empty, space.Tenant);
			Assert.Equal(0, space.Packages);
		}
	}
}
