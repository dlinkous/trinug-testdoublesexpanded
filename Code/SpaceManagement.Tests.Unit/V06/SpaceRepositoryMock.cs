using System;
using System.Collections.Generic;

namespace SpaceManagement.Tests.Unit.V06
{
	internal class SpaceRepositoryMock : ISpaceRepository
	{
		internal Queue<Tuple<int, Space>> ReadQueue { get; private set; } = new Queue<Tuple<int, Space>>();

		public void Create(Space space) =>
			throw new InvalidOperationException();

		public Space Read(int location)
		{
			var item = ReadQueue.Dequeue();
			if (item.Item1 != location) throw new InvalidOperationException();
			return item.Item2;
		}

		public void Update(Space space) =>
			throw new InvalidOperationException();

		public void Delete(int location) =>
			throw new InvalidOperationException();

		internal void SetupRead(int location) => ReadQueue.Enqueue(new Tuple<int, Space>(location, new Space()
		{
			Location = location
		}));
	}
}
