
using FeWebDemo.Library;
using Foundation;

namespace FeWebDemo.Ios.Library
{
	public class IosSystemInformationProvider : ISystemInformationProvider
	{
		public string GetBuildNumber()
		{
			return NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleVersion")].ToString();
		}

		public string GetVersionNumber()
		{
			return NSBundle.MainBundle.InfoDictionary[new NSString("CFBundleShortVersionString")].ToString();

		}


	}
}
