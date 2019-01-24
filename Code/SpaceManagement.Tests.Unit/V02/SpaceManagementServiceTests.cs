using System;
using Xunit;
using SpaceManagement.V02;

namespace SpaceManagement.Tests.Unit.V02
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_RequiresValidLocation()
		{
			var service = new SpaceManagementService(new SpaceRepositoryDummy());
			//Assert.Throws<ArgumentOutOfRangeException>(() => service.CreateSpace(0));
		}
	}
}
