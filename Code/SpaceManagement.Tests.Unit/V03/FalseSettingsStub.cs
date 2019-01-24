using System;

namespace SpaceManagement.Tests.Unit.V03
{
	internal class FalseSettingsStub : ISettings
	{
		public bool SpaceCreationAllowed => false;
	}
}
