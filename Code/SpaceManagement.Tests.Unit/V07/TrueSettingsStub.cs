using System;

namespace SpaceManagement.Tests.Unit.V07
{
	internal class TrueSettingsStub : ISettings
	{
		public bool SpaceCreationAllowed => true;
	}
}
