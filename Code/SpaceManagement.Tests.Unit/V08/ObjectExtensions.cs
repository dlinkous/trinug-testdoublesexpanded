using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SpaceManagement.Tests.Unit.V08
{
	public static class ObjectExtensions
	{
		public static T Copy<T>(this T original)
		{
			var formatter = new BinaryFormatter();
			using (var stream = new MemoryStream())
			{
				formatter.Serialize(stream, original);
				stream.Position = 0;
				return (T)formatter.Deserialize(stream);
			}
		}
	}
}
