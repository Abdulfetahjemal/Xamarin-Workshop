using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using UIKit;
using Weather;
using Weather.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace Weather.iOS
{
    class CustomFrameRenderer : FrameRenderer
    {

        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            base.LayoutSubviews();
            this.Layer.ShadowRadius = 2.0f;
            this.Layer.ShadowColor = UIColor.Red.CGColor;
         
        }
    }
}