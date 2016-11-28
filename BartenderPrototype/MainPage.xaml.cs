using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BartenderPrototype
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			BindingContext = new BottlesViewModel();
		}
	}
}
