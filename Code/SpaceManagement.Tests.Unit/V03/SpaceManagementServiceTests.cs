using System;
using Xunit;
using SpaceManagement.V03;

namespace SpaceManagement.Tests.Unit.V03
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_RequiresValidLocation()
		{
			var service = new SpaceManagementService(new SpaceRepositoryDummy(), new SettingsDummy());
			Assert.Throws<ArgumentOutOfRangeException>(() => service.CreateSpace(0));
		}

		[Fact]
		public void CreateSpace_WhenSpaceCreationIsNotAllowed_ThrowsInvalidOperationException()
		{
			var service = new SpaceManagementService(new SpaceRepositoryDummy(), new FalseSettingsStub());
			Assert.Throws<InvalidOperationException>(() => service.CreateSpace(1));
		}
	}
}
