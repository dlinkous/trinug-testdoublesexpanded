using System;

namespace SpaceManagement.Tests.Unit.V05
{
	internal class TrueSettingsStub : ISettings
	{
		public bool SpaceCreationAllowed => true;
	}
}
