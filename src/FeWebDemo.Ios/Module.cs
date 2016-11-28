using System;
using FeWebDemo.Ios.Library;
using FeWebDemo.Library;
using Ninject.Modules;

namespace FeWebDemo.Ios
{
	public class Module : NinjectModule
	{
		public override void Load()
		{
			this.Bind<ISystemInformationProvider>().To<IosSystemInformationProvider>();
			this.Bind<ISystemInformationService>().To<SystemInformationService>();
		}
	}
}
