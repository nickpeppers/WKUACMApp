// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace WKUACMChapter
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton _acmLink { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITableView _table { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_acmLink != null) {
				_acmLink.Dispose ();
				_acmLink = null;
			}

			if (_table != null) {
				_table.Dispose ();
				_table = null;
			}
		}
	}
}
