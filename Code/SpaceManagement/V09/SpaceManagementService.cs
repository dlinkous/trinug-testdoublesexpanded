using System;

namespace SpaceManagement.V09
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

		public void AssignTenant(int location, string tenant)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			var space = spaceRepository.Read(location);
			if (space == null) throw new InvalidSpaceException();
			space.Tenant = tenant;
			space.Packages = 0;
			spaceRepository.Update(space);
		}

		public void UnassignTenant(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			var space = spaceRepository.Read(location);
			if (space == null) throw new InvalidSpaceException();
			space.Tenant = string.Empty;
			space.Packages = 0;
			spaceRepository.Update(space);
		}

		public void IncrementPackages(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			var space = spaceRepository.Read(location);
			if (space == null) throw new InvalidSpaceException();
			space.Packages++;
			spaceRepository.Update(space);
		}

		public void ClearPackages(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			var space = spaceRepository.Read(location);
			if (space == null) throw new InvalidSpaceException();
			space.Packages = 0;
			spaceRepository.Update(space);
		}

		public int GetPackages(int location)
		{
			if (location <= 0) throw new ArgumentOutOfRangeException(nameof(location));
			var space = spaceRepository.Read(location);
			if (space == null) throw new InvalidSpaceException();
			return space.Packages;
		}
	}
}
