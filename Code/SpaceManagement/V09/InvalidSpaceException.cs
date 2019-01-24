using System;
using System.Runtime.Serialization;

namespace SpaceManagement.V09
{
	[Serializable]
	public class InvalidSpaceException : Exception
	{
		public InvalidSpaceException() { }

		public InvalidSpaceException(string message) : base(message) { }

		public InvalidSpaceException(string message, Exception innerException) : base(message, innerException) { }

		protected InvalidSpaceException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
