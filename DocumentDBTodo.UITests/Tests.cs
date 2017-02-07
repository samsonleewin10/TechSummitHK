using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DocumentDBTodo.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void AppLaunches()
		{
            app.Screenshot("App Launches");
		}

		[Test]
		public void LoginWrong()
		{
			//app.Tap(x => x.Marked("Input Your Username here"));
            //app.EnterText(x => x.Class("UITextField").Text("Samson"), " ");
            //app.PressEnter();
            //app.Tap(x => x.Marked("Input Your Password here"));
            //app.EnterText(x => x.Class("UITextField").Index(1), "P@ssw0rd!");
            //app.PressEnter();
            app.Tap(x => x.Marked("Login"));
			app.Screenshot("Login with wrong credentials");
		}

        public void LoginRight()
        {
            app.Tap(x => x.Marked("OK"));
            app.Tap(x => x.Marked("Input Your Username here"));
            app.EnterText(x => x.Class("UITextField"), "Samson");
            app.PressEnter();
            app.Tap(x => x.Marked("Input Your Password here"));
            app.EnterText(x => x.Class("UITextField").Index(1), "P@ssw0rd");
            app.PressEnter();
            app.Tap(x => x.Marked("Login"));
            app.Screenshot("Login with right credentials");
        }


        //[Test]
        //public void DisplayErrorMessage_WrongPassword()
        //{
        //	app.Tap(x => x.Marked("OK"));
        //	app.Screenshot("Tapped on view with class: _UIAlertControllerActionView marked: OK");
        //}

        //[Test]
        //public void InteractWithEventPage()
        //{
        //	app.ScrollUp();
        //	app.Screenshot("Swipped down");
        //	app.Tap(x => x.Text("Browse Events"));
        //	app.Screenshot("Browse Events");
        //	app.Tap(x => x.Marked("Back"));
        //  app.Screenshot("Back to MainPage");
        //}
    }
}
