using System;

using Xamarin.Forms;

using SpotifyAPI.Web; //Base Namespace
//using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

namespace SpotifyForms
{
	public class App : Application
	{
		private static SpotifyWebAPI _spotify;

		public App()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "SpotifyForms",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
		}

		protected override async void OnStart()
		{
			// Handle when your app starts
			_spotify = new SpotifyWebAPI()
			{
				UseAuth = false, //This will disable Authentication.
			};

			FullTrack track = await _spotify.GetTrack("3Hvu1pq89D4R0lyPBoujSv");
			System.Diagnostics.Debug.WriteLine(track.Name); //Yeay! We just printed a tracks name.
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
