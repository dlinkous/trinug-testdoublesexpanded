using System;

namespace SpaceManagement.Tests.Unit.V03
{
	internal class SettingsDummy : ISettings
	{
		public bool SpaceCreationAllowed => throw new TestDoubleDummyException();
	}
}
