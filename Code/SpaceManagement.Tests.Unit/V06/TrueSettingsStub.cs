using System;

namespace SpaceManagement.Tests.Unit.V06
{
	internal class TrueSettingsStub : ISettings
	{
		public bool SpaceCreationAllowed => true;
	}
}
