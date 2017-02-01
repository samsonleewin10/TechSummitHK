﻿using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace DocumentDBTodo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			MainPage = new LoginPage();

			MobileCenter.Start(typeof(Analytics), typeof(Crashes));
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
