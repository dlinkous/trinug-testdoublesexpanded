using System;
using Xunit;
using SpaceManagement.V04;

namespace SpaceManagement.Tests.Unit.V04
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_WhenSpaceCreationIsNotAllowed_ThrowsInvalidOperationException()
		{
			var settings = new SettingsStub()
			{
				SpaceCreationAllowedValue = false
			};
			var service = new SpaceManagementService(new SpaceRepositoryDummy(), settings);
			Assert.Throws<InvalidOperationException>(() => service.CreateSpace(1));
		}
	}
}
