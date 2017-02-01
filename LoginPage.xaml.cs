using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DocumentDBTodo
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();

			loginImage.Source = ImageSource.FromFile("TechSummitLogo.png");

			LoginBtn.Clicked += LoginBtn_Clicked;
		}

		public async void LoginBtn_Clicked(object sender, EventArgs e)
		{

			if (pwdInput.Text == "P@ssw0rd")
			{
				var selection = await DisplayAlert("Identity Confirmation", "Welcome back, " + nameInput.Text + "!", "Thanks!", "I'm not " + nameInput.Text);

				if (selection == true)
				{
					App.Current.MainPage = new DocumentDBTodoPage();
				}
				else
				{
					await DisplayAlert("Danger", "Since you are not the owner of this account, your app is going to crash now!", "What!?");

					int crasher = 0;
					int crashtaker = 5;
					int crashnow = crashtaker / crasher;
				}
			}
			else
			{
				await DisplayAlert("Login Failure", "Your password is incorrect. Please retry.", "OK");
			}
		}
	}
}
