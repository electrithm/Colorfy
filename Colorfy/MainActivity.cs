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
    //set some info
    [Activity(Label = "Colorfy", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        //create background
        private LinearLayout background;

        //create randomizer
        Random rnd = new Random();

        //when the app loads
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //get background
            background = FindViewById<LinearLayout>(Resource.Id.background);

            //if the background is clicked
            background.Click += delegate
            {
                //change the color by creating a random rgb value
                background.SetBackgroundColor(Color.Rgb(rnd.Next(0,255),rnd.Next(0,255),rnd.Next(0,255)));
            };
        }
    }
}

