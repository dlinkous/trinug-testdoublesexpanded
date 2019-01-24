using System;

namespace SpaceManagement
{
	[Serializable]
	public class Space
	{
		public int Location { get; set; }
		public string Tenant { get; set; }
		public int Packages { get; set; }
	}
}
