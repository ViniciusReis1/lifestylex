using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LifeStyle.Droid
{
	[Activity (Label = "LifeStyle.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{


		protected override void OnCreate (Bundle bundle)
		{
			Xamarin.Insights.Initialize (global::LifeStyle.Droid.XamarinInsights.ApiKey, this);
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			//string dbPath = SQLite_Android.GetLocalFilePath("socialNetworkDBase.db3");

			LoadApplication (new App());
		}
	}


}
