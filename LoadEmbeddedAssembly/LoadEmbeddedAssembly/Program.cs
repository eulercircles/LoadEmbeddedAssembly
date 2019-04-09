using System;
using System.Reflection;

namespace LoadEmbeddedAssembly
{
	internal class Program
	{
		static void Main(string[] args)
		{
			AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
		}

		private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
		{
			throw new NotImplementedException();
		}

		private Assembly LoadEmbeddedAssembly(string resourcePath)
		{
			var path = Assembly.GetManifestResourceNames()
		}
	}
}
