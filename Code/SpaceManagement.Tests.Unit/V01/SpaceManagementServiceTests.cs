using System;
using Xunit;
using SpaceManagement.V01;

namespace SpaceManagement.Tests.Unit.V01
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_RequiresValidLocation()
		{
			var service = new SpaceManagementService(new SpaceRepositoryDummy());
			Assert.Throws<ArgumentOutOfRangeException>(() => service.CreateSpace(0));
		}
	}
}
