using System;
using Xunit;
using SpaceManagement.V06;

namespace SpaceManagement.Tests.Unit.V06
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_WhenSpaceAlreadyExists_ThrowsDuplicateSpaceException_1()
		{
			var repository = new SpaceRepositoryMock();
			var service = new SpaceManagementService(repository, new TrueSettingsStub(), new LoggerStub());
			const int location = 999;
			repository.ReadQueue.Enqueue(new Tuple<int, Space>(location, new Space()
			{
				Location = location,
			}));
			Assert.Throws<DuplicateSpaceException>(() => service.CreateSpace(location));
			Assert.Empty(repository.ReadQueue);
		}

		[Fact]
		public void CreateSpace_WhenSpaceAlreadyExists_ThrowsDuplicateSpaceException_2()
		{
			var repository = new SpaceRepositoryMock();
			var service = new SpaceManagementService(repository, new TrueSettingsStub(), new LoggerStub());
			const int location = 999;
			repository.SetupRead(location);
			Assert.Throws<DuplicateSpaceException>(() => service.CreateSpace(location));
			Assert.Empty(repository.ReadQueue);
		}
	}
}
