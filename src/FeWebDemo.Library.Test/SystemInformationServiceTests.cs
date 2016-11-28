using NUnit.Framework;
using System;
namespace FeWebDemo.Library
{
	[TestFixture()]
	public class SystemInformationServiceTests
	{
		[Test()]
		public void GetSystemVersionNumber_WhenCalled_ShouldReturnTheApplicationVersionNumber()
		{
			var versionNumber = "2.5";
			var buildNumber = "99";
			var expected = "2.5.99";
			var sut = new SystemInformationService(new FakeSysteminformationProvider(versionNumber,buildNumber));

			var actual = sut.GetSystemVersionNumber();


			Assert.AreEqual(expected, actual);

		}
	}


}
