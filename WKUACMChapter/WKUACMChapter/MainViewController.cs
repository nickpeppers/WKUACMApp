using MonoTouch.UIKit;
using System;
using MonoTouch.Foundation;

namespace WKUACMChapter
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController(IntPtr handle) : base (handle)
        {
           
        }
		
        [Obsolete]
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
        }
		
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavigationController.SetNavigationBarHidden(true, false);

            _acmLink.TouchUpInside += (sender, e) => 
            {
                using (var url = NSUrl.FromString ("http://www.acm.org/"))
                {
                    UIApplication.SharedApplication.OpenUrl (url);
                }
            };

        }
		
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }
    }
}

