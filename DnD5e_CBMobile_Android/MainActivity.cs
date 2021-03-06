﻿using System;
using Android.App;
using Android.Views;
using Android.OS;
using Android.Support.V7.App;
using Toolbar = Android.Support.V7.Widget.Toolbar;
using System.Collections;
using Android.Content;
using Android.Widget;
using Android.Text;

namespace DnD5e_CBMobile_Android
{
	
	[Activity (MainLauncher = true, Theme = "@style/MainAppTheme")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.start_page);

			var toolbar = FindViewById<Toolbar> (Resource.Id.toolbar);
			SetSupportActionBar (toolbar);

			SupportActionBar.Title = "D&D Character Creator";

		}

		//Setup my Menu
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.home, menu);
			return base.OnCreateOptionsMenu (menu);
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			Intent intent;
			switch (item.ItemId) {
			case Resource.Id.new_char:
				intent = new Intent (this, typeof(CharacterSheetActivity));
				intent.PutExtra ("loadCharacter", "false");
				StartActivity (intent);
				return true;
			case Resource.Id.load_char:
				Toast.MakeText (this, "Load Character Pressed", ToastLength.Short).Show ();
				intent = new Intent (this, typeof(CharacterSheetActivity));
				intent.PutExtra ("loadCharacter", "true");
				StartActivity (intent);
				return true;
			}
			return true;
		}
			
	}
}


