using System;
using FeWebDemo.Library;
using UIKit;
using Ninject;

namespace FeWebDemo.Ios
{
	public partial class ViewController : UIViewController
	{
		private ISystemInformationService _systemInformationService;
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			_systemInformationService = App.Container.Get<ISystemInformationService>();
			lblVersionText.TextColor = UIColor.White;
			lblVersion.Text = _systemInformationService.GetSystemVersionNumber();
			lblVersion.TextColor = UIColor.White;
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
