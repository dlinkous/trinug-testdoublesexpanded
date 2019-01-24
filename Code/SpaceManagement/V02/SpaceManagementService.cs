using System;

namespace SpaceManagement.V02
{
	public class SpaceManagementService
	{
		private readonly ISpaceRepository spaceRepository;

		public SpaceManagementService(ISpaceRepository spaceRepository) =>
			this.spaceRepository = spaceRepository ?? throw new ArgumentNullException(nameof(spaceRepository));

		public void CreateSpace(int location)
		{
			spaceRepository.Create(new Space()
			{
				Location = location,
				Tenant = string.Empty,
				Packages = 0
			});
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			throw new NotImplementedException();
		}
	}
}
