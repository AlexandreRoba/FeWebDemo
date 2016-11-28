namespace FeWebDemo.Library
{
	public class SystemInformationService : ISystemInformationService
	{
		private readonly ISystemInformationProvider _systemInformationProvider;

		public SystemInformationService(ISystemInformationProvider systemInformationProvider)
		{
			_systemInformationProvider = systemInformationProvider;
		}

		public string GetSystemVersionNumber()
		{
			var versionNumber = _systemInformationProvider.GetVersionNumber();
			var buildNumber = _systemInformationProvider.GetBuildNumber();
			return string.Format("{0}.{1}", versionNumber, buildNumber);
		}
	}
}
