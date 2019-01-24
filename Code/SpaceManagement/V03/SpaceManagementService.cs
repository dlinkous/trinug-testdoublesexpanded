using System;

namespace SpaceManagement.V03
{
	public class SpaceManagementService
	{
		private readonly ISpaceRepository spaceRepository;
		private readonly ISettings settings;

		public SpaceManagementService(ISpaceRepository spaceRepository, ISettings settings)
		{
			this.spaceRepository = spaceRepository ?? throw new ArgumentNullException(nameof(spaceRepository));
			this.settings = settings ?? throw new ArgumentNullException(nameof(settings));
		}

		public void CreateSpace(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			if (!settings.SpaceCreationAllowed) throw new InvalidOperationException("Space creation is not allowed.");
			throw new NotImplementedException();
		}
	}
}
