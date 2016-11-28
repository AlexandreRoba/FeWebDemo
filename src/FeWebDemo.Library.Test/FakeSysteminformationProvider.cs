using System;

namespace FeWebDemo.Library
{
	class FakeSysteminformationProvider : ISystemInformationProvider
	{
		private string _version;
		private string _build;

		public FakeSysteminformationProvider(string version, string build)
		{
			this._version = version;
			this._build = build;
		}

		public string GetBuildNumber()
		{
			return this._build;
		}

		public string GetVersionNumber()
		{
			return this._version;
		}
	}
}