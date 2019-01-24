using System;
using Xunit;
using SpaceManagement.V09;

namespace SpaceManagement.Tests.Unit.V09
{
	public class SpaceManagementServiceTests
	{
		[Fact]
		public void MultipleActiveTenantTest()
		{
			var repository = new SpaceRepositoryFake();
			var service = new SpaceManagementService(repository, new TrueSettingsStub(), new LoggerStub());
			const int alice = 1001;
			const string aliceName = "Alice";
			service.CreateSpace(alice);
			service.AssignTenant(alice, aliceName);
			service.IncrementPackages(alice);
			service.IncrementPackages(alice);
			Assert.Equal(2, service.GetPackages(alice));
			Assert.Equal(2, service.GetPackages(alice));
			service.AssignTenant(alice, aliceName);
			Assert.Equal(0, service.GetPackages(alice));
			service.IncrementPackages(alice);
			service.IncrementPackages(alice);
			Assert.Equal(2, service.GetPackages(alice));
			Assert.Equal(aliceName, repository.spaces[alice].Tenant);
			service.UnassignTenant(alice);
			Assert.Equal(string.Empty, repository.spaces[alice].Tenant);
			Assert.Equal(0, service.GetPackages(alice));
			service.AssignTenant(alice, aliceName);
			Assert.Equal(aliceName, repository.spaces[alice].Tenant);
			Assert.Equal(0, service.GetPackages(alice));
			service.IncrementPackages(alice);
			service.IncrementPackages(alice);
			Assert.Equal(2, service.GetPackages(alice));
			service.ClearPackages(alice);
			Assert.Equal(0, service.GetPackages(alice));
			service.IncrementPackages(alice);
			service.IncrementPackages(alice);
			Assert.Equal(2, service.GetPackages(alice));
			const int bob = 1002;
			const string bobName = "Bob";
			service.CreateSpace(bob);
			Assert.Equal(string.Empty, repository.spaces[bob].Tenant);
			service.AssignTenant(bob, bobName);
			Assert.Equal(bobName, repository.spaces[bob].Tenant);
			service.IncrementPackages(bob);
			service.ClearPackages(bob);
			service.IncrementPackages(bob);
			service.IncrementPackages(bob);
			service.IncrementPackages(bob);
			Assert.Equal(3, service.GetPackages(bob));
			Assert.Equal(2, service.GetPackages(alice));
		}
	}
}
