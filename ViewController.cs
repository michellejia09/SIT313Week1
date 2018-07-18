using System;
using System.Drawing;
using UIKit;

namespace Week1
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        UIButton imgButton;
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        
            imgButton = UIButton.FromType(UIButtonType.Custom);
            imgButton.Frame = new RectangleF(0, 0, float.Parse(View.Bounds.Width.ToString()),
                                              float.Parse(View.Bounds.Height.ToString()));
            imgButton.SetImage(UIImage.FromFile("off.png"), UIControlState.Normal);
            View.AddSubview(imgButton);

            var imageSwitch = false;
            imgButton.TouchUpInside += delegate {
                if (imageSwitch)
                {
                    imgButton.SetImage(UIImage.FromFile("off.png"),UIControlState.Normal);
                    imageSwitch = false;
                }
                else 
                {
                    imgButton.SetImage(UIImage.FromFile("on.png"),UIControlState.Normal);
                    imageSwitch = true;
                }
            };

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

    }
}
