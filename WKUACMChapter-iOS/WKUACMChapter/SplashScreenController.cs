using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WKUACMChapter
{
	public partial class SplashScreenController : UIViewController
	{
		public SplashScreenController (IntPtr handle) : base (handle)
		{
		}

        [Obsolete ("Deprecated in iOS6. Replace it with both GetSupportedInterfaceOrientations and PreferredInterfaceOrientationForPresentation")]
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            return toInterfaceOrientation == UIInterfaceOrientation.Portrait;
        }
        
        public override bool ShouldAutorotate()
        {
            return false;
        }
        
        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.Portrait;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, false);
        }
        
        [Obsolete] 
        public override void ViewDidUnload()
        {
            base.ViewDidUnload();
            
            ReleaseDesignerOutlets();
        }
        
        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            
            UIView.Animate(.5, 0, UIViewAnimationOptions.CurveEaseInOut, () => _splash1.Alpha = 1, OnSplash1FadeIn);
        }
        
        private void OnSplash1FadeIn()
        {
            UIView.Animate(.5, 1, UIViewAnimationOptions.CurveEaseInOut, () => _splash1.Alpha = 0, OnSplashMainFadeIn);
        }
       
        private void OnSplashMainFadeIn()
        {
            PerformSegue ("MainScreen", this);
        }
	}
}
