using Android.App;
using Android.Widget;
using Android.OS;
using Ninject;
using FeWebDemo.Library;

namespace FeWebDemo.Android
{
	[Activity(Label = "FeWebDemo.Android", MainLauncher = true, Icon = "@mipmap/icon", Theme="@android:style/Theme.NoTitleBar")]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);


			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			ISystemInformationService _systemInformationService = App.Container.Get<ISystemInformationService>();

			TextView lblVersionNumber = FindViewById<TextView>(Resource.Id.lblVersionNumber);

			lblVersionNumber.Text = _systemInformationService.GetSystemVersionNumber();
		}
	}
}

