using System;
using System.Collections.Generic;
using MR.Gestures;
using Xamarin.Forms;

namespace BartenderPrototype
{
	public partial class MainPage : Xamarin.Forms.ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new BottlesViewModel();
		}

		void OnTapped(object sender, TapEventArgs e)
		{
			Line.HeightRequest = e.Center.Y;
		}
	}
}
