using Weather;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weather.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace Weather.Droid
{
    public class CustomFrameRenderer : FrameRenderer
    {
        public CustomFrameRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement.HasShadow)
            {
                SetOutlineSpotShadowColor(Android.Graphics.Color.White);
                Elevation = 50.0f;


            }
        }
    }
}