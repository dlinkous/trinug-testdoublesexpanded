using System;

namespace SpaceManagement.V08
{
	public class SpaceManagementService
	{
		private readonly ISpaceRepository spaceRepository;
		private readonly ISettings settings;
		private readonly ILogger logger;

		public SpaceManagementService(ISpaceRepository spaceRepository, ISettings settings, ILogger logger)
		{
			this.spaceRepository = spaceRepository ?? throw new ArgumentNullException(nameof(spaceRepository));
			this.settings = settings ?? throw new ArgumentNullException(nameof(settings));
			this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}

		public void CreateSpace(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			if (!settings.SpaceCreationAllowed) throw new InvalidOperationException("Space creation is not allowed.");
			logger.Log($"Creating space {location}...");
			if (spaceRepository.Read(location) != null) throw new DuplicateSpaceException();
			spaceRepository.Create(new Space()
			{
				Location = location,
				Tenant = string.Empty,
				Packages = 0
			});
		}
	}
}
