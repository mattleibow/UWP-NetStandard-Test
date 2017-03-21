using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ClassLibrary1
{
	public class Class1
	{
		public static bool Test(Stream stream)
		{
			var reader = XmlReader.Create(stream);
			return reader.Read();
		}
	}
}
