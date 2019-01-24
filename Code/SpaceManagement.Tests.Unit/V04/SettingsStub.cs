using System;

namespace SpaceManagement.Tests.Unit.V04
{
	internal class SettingsStub : ISettings
	{
		internal bool SpaceCreationAllowedValue { get; set; }

		public bool SpaceCreationAllowed => SpaceCreationAllowedValue;
	}
}
