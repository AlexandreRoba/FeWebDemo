using System;
using Android.Content;
using Android.Content.PM;
using FeWebDemo.Library;

namespace FeWebDemo.Android.Library
{
	public class AndroidSystemInformationProvider : ISystemInformationProvider
	{
		Context _context;

		public AndroidSystemInformationProvider(Context context)
		{
			_context = context;
		}

		public string GetBuildNumber()
		{
			PackageInfo pInfo = _context.PackageManager.GetPackageInfo(_context.PackageName,0);
			return pInfo.VersionName;
		}

		public string GetVersionNumber()
		{
			PackageInfo pInfo = _context.PackageManager.GetPackageInfo(_context.PackageName, 0);
			return pInfo.VersionCode.ToString();
		}
	}
}
