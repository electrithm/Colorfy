using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;


namespace Colorfy
{
    [Activity(Label = "Colorfy", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private LinearLayout background;
        int count = 1;
        Random rnd = new Random();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            background = FindViewById<LinearLayout>(Resource.Id.background);

            button.Click += delegate
            {
                button.Text = string.Format("{0} clicks!", count++);
                background.SetBackgroundColor(Color.Rgb(rnd.Next(0,255),rnd.Next(0,255),rnd.Next(0,255)));
            };
        }
    }
}

