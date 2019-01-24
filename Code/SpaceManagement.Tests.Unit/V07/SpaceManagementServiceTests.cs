using System;
using Xunit;
using SpaceManagement.V07;

namespace SpaceManagement.Tests.Unit.V07
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void CreateSpace_WhenSpaceAlreadyExists_ThrowsDuplicateSpaceException()
		{
			var repository = new SpaceRepositoryMock();
			var service = new SpaceManagementService(repository, new TrueSettingsStub(), new LoggerStub());
			const int location = 999;
			var readFuncWasCalled = false;
			repository.ReadFunc = loc =>
			{
				readFuncWasCalled = true;
				Assert.Equal(location, loc);
				return new Space()
				{
					Location = loc
				};
			};
			Assert.Throws<DuplicateSpaceException>(() => service.CreateSpace(location));
			Assert.True(readFuncWasCalled);
		}
	}
}
