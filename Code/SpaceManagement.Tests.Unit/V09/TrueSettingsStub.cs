using System;

namespace SpaceManagement.Tests.Unit.V09
{
	internal class TrueSettingsStub : ISettings
	{
		public bool SpaceCreationAllowed => true;
	}
}
