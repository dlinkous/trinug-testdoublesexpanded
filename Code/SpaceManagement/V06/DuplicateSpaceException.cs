using System;
using System.Runtime.Serialization;

namespace SpaceManagement.V06
{
	[Serializable]
	public class DuplicateSpaceException : Exception
	{
		public DuplicateSpaceException() { }

		public DuplicateSpaceException(string message) : base(message) { }

		public DuplicateSpaceException(string message, Exception innerException) : base(message, innerException) { }

		protected DuplicateSpaceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
