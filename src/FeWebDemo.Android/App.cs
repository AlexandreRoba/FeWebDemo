using System;
using Android.App;
using Android.Runtime;
using Ninject;

namespace FeWebDemo.Android
{
	[Application(Icon = "@drawable/icon", Label = "@string/app_name")]
	public class App : Application
	{
		public static IKernel Container { get; set; }

		public App(IntPtr h, JniHandleOwnership jho) : base(h, jho)
		{
			
		}

		public override void OnCreate()
		{
			var kernel = new Ninject.StandardKernel(new Module(this.BaseContext));

			App.Container = kernel;

			base.OnCreate();
		}
	}
}
