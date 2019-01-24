using System;

namespace SpaceManagement
{
	public interface ISpaceRepository
	{
		void Create(Space space);
		Space Read(int location);
		void Update(Space space);
		void Delete(int location);
	}
}
