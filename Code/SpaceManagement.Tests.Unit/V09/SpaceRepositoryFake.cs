using System;
using System.Collections.Generic;

namespace SpaceManagement.Tests.Unit.V09
{
	internal class SpaceRepositoryFake : ISpaceRepository
	{
		internal readonly Dictionary<int, Space> spaces = new Dictionary<int, Space>();

		public void Create(Space space) => spaces.Add(space.Location, space.Copy());

		public Space Read(int location) => spaces.TryGetValue(location, out Space space) ? space : null;

		public void Update(Space space) => spaces[space.Location] = space.Copy();

		public void Delete(int location) => spaces.Remove(location);
	}
}
