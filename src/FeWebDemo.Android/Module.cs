
using Android.Content;
using FeWebDemo.Android.Library;
using FeWebDemo.Library;
using Ninject.Modules;

namespace FeWebDemo.Android
{
	public class Module : NinjectModule
	{
		Context _context;

		public Module(Context context)
		{
			_context = context;
		}

		public override void Load()
		{
			this.Bind<ISystemInformationProvider>().To<AndroidSystemInformationProvider>().WithConstructorArgument("context",_context);
			this.Bind<ISystemInformationService>().To<SystemInformationService>();
		}
	}
}
