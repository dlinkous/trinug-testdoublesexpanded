using System;

namespace SpaceManagement.Tests.Unit.V01
{
	internal class SpaceRepositoryDummy : ISpaceRepository
	{
		public void Create(Space space) =>
			throw new TestDoubleDummyException();

		public Space Read(int location) =>
			throw new TestDoubleDummyException();

		public void Update(Space space) =>
			throw new TestDoubleDummyException();

		public void Delete(int location) =>
			throw new TestDoubleDummyException();
	}
}
