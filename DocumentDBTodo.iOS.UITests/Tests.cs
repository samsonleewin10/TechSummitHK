using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace DocumentDBTodo.iOS.UITests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest()
		{
			// TODO: If the iOS app being tested is included in the solution then open
			// the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			//
			// The iOS project should have the Xamarin.TestCloud.Agent NuGet package
			// installed. To start the Test Cloud Agent the following code should be
			// added to the FinishedLaunching method of the AppDelegate:
			//
			//    #if ENABLE_TEST_CLOUD
			//    Xamarin.Calabash.Start();
			//    #endif
			app = ConfigureApp
				.iOS
				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				//.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/DocumentDBTodo.iOS.UITests.iOS.app")
				.StartApp();
		}

		[Test]
		public void AppLaunches()
		{
			app.Screenshot("First screen.");
		}

		[Test]
		public void Login()
		{
			app.Tap(x => x.Marked("Input Your Username here"));
			app.EnterText(x => x.Class("UITextField").Text("Samson"), " ");
			app.PressEnter();
			app.Tap(x => x.Marked("Input Your Password here"));
			app.EnterText(x => x.Class("UITextField").Index(1), "P@ssw0rd!");
			app.PressEnter();
			app.Tap(x => x.Marked("Login"));
			app.Screenshot("Tapped on view with class: UIButton marked: Login");
		}

		[Test]
		public void DisplayErrorMessage_WrongPassword()
		{
			app.WaitForElement(c => c.Marked("OK").Text("OK"));
			app.Tap(x => x.Marked("OK"));
			app.Screenshot("Tapped on view with class: _UIAlertControllerActionView marked: OK");
		}
	}
}
