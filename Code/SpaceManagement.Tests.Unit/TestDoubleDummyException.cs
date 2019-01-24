using System;
using System.Runtime.Serialization;

namespace SpaceManagement.Tests.Unit
{
	[Serializable]
	public class TestDoubleDummyException : Exception
	{
		public TestDoubleDummyException() { }

		public TestDoubleDummyException(string message) : base(message) { }

		public TestDoubleDummyException(string message, Exception innerException) : base(message, innerException) { }

		protected TestDoubleDummyException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}
