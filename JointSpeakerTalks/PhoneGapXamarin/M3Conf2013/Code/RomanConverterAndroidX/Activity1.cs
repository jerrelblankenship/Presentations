using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace RomanConverterAndroidX
{
	using RomanConverterSharedBase;

	[Activity(Label = "RomanConverterAndroidX", MainLauncher = true, Icon = "@drawable/icon")]
	public class Activity1 : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			var layout = new LinearLayout(this);
			layout.Orientation = Orientation.Vertical;

			var aLabel = new TextView(this);
			aLabel.Text = "Please Enter an Arabic to Convert:";

			var arabicNumber = new EditText(this);
			var romanResult = new TextView(this);

			var nrButton = new Button(this);
			nrButton.Text = "Convert To Roman";
			nrButton.Click += (sender, e) =>
			{
				var converter = new RomanNumeralConverter();

				romanResult.Text = converter.NumberToRoman(Convert.ToInt32(arabicNumber.Text));
			};


			layout.AddView(aLabel);
			layout.AddView(arabicNumber);
			layout.AddView(nrButton);
			layout.AddView(romanResult);
			SetContentView(layout);
		}
	}
}

