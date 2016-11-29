using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace BartenderPrototype.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			MR.Gestures.iOS.Settings.LicenseKey = "ALZ9-BPVU-XQ35-CEBG-5ZRR-URJQ-ED5U-TSY8-6THP-3GVU-JW8Z-RZGE-CQW6";           // key for GestureSample

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
