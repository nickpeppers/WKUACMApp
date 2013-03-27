// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace WKUACMChapter
{
	[Register ("MainCell")]
	partial class MainCell
	{
		[Outlet]
		MonoTouch.UIKit.UILabel _time { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _location { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _speaker { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel _subject { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_time != null) {
				_time.Dispose ();
				_time = null;
			}

			if (_location != null) {
				_location.Dispose ();
				_location = null;
			}

			if (_speaker != null) {
				_speaker.Dispose ();
				_speaker = null;
			}

			if (_subject != null) {
				_subject.Dispose ();
				_subject = null;
			}
		}
	}
}
