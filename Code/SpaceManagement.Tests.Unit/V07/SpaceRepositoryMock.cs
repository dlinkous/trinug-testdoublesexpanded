using System;

namespace SpaceManagement.Tests.Unit.V07
{
	internal class SpaceRepositoryMock : ISpaceRepository
	{
		internal Func<int, Space> ReadFunc { get; set; }

		public void Create(Space space) =>
			throw new InvalidOperationException();

		public Space Read(int location) => ReadFunc(location);

		public void Update(Space space) =>
			throw new InvalidOperationException();

		public void Delete(int location) =>
			throw new InvalidOperationException();
	}
}
