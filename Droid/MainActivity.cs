using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace DivisasNative.Droid
{
    [Activity(Label = "Divisas Native", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
		#region Controls
		EditText editTextPesos;
		EditText editTextDollars;
		EditText editTextEuros;
		EditText editTextPounds;
        Button buttonConvert;
		#endregion

		protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

			editTextPesos = FindViewById<EditText>(Resource.Id.editTextPesos);
			editTextDollars = FindViewById<EditText>(Resource.Id.editTextDollars);
			editTextEuros = FindViewById<EditText>(Resource.Id.editTextEuros);
			editTextPounds = FindViewById<EditText>(Resource.Id.editTextPounds);
			buttonConvert = FindViewById<Button>(Resource.Id.buttonConvert);

            buttonConvert.Click += ButtonConvert_Click;
		}

        void ButtonConvert_Click(object sender, EventArgs e)
        {
            
        }
    }
}

