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

		void positionLine(double y)
		{
			Xamarin.Forms.AbsoluteLayout.SetLayoutFlags(Line, AbsoluteLayoutFlags.WidthProportional);
			Xamarin.Forms.AbsoluteLayout.SetLayoutBounds(Line, new Rectangle(0, y, 1, 10));
		}

		void OnTapped(object sender, TapEventArgs e)
		{
			positionLine(e.Center.Y);
		}

		void OnPanning(object sender, PanEventArgs e)
		{
			positionLine(e.Center.Y);
		}
	}
}
