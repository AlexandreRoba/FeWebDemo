using System;
using Ninject;
namespace FeWebDemo.Ios
{
	public static class App
	{
		public static StandardKernel Container { get; set; }

		public static void Initialize()
		{
			var kernel = new StandardKernel(new Module());
			Container = kernel;
		}

	}
}
