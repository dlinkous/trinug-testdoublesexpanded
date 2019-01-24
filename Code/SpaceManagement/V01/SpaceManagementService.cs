using System;

namespace SpaceManagement.V01
{
	public class SpaceManagementService
	{
		private readonly ISpaceRepository spaceRepository;

		public SpaceManagementService(ISpaceRepository spaceRepository) =>
			this.spaceRepository = spaceRepository ?? throw new ArgumentNullException(nameof(spaceRepository));

		public void CreateSpace(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			throw new NotImplementedException();
		}
	}
}
