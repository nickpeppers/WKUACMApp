using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WKUACMChapter
{
	public partial class MainCell : UITableViewCell
	{
		public MainCell (IntPtr handle) : base (handle)
		{
		}

        public override void AwakeFromNib ()
        {
            base.AwakeFromNib ();
            
        }
        
        public void Update(NSIndexPath indexPath)
        {
            switch (indexPath.Row)
            {
                case 0:
                    _time.Text = "3/27/2013 5:00 P.M.";
                    _location.Text = "SH 1102";
                    _speaker.Text = "Dr. Wang";
                    _subject.Text = "Presentation on data mining";
                    break;
                case 1 :
                    _time.Text = "2/20/2013 5:00 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Mike Maddox";
                    _subject.Text = "Introduction of Fiserv";
                    break;
                case 2:
                    _time.Text = "11/28/2012 5:00 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Jon Peppers";
                    _subject.Text = "Talk on Xamarin mobile development";
                    break;
                case 3 :
                    _time.Text = "10/24/2012 5:00 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Dr. Ziegler";
                    _subject.Text = "Presentation on android development";
                    break;
                case 4:
                    _time.Text = "9/26/2012 4:45 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Dr. Qi Li";
                    _subject.Text = "Agenda discussion";
                    break;
                case 5 :
                    _time.Text = "3/19/2012 4:30 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Jon Peppers";
                    _subject.Text = "Hitcents developer";
                    break;
                case 6:
                    _time.Text = "2/6/2012 4:30 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Local Company";
                    _subject.Text = "Company job opportunities";
                    break;
                case 7 :
                    _time.Text = "11/16/2011 5:00 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Dr. Gary";
                    _subject.Text = "Parallel Programming with MPI";
                    break;
                case 8:
                    _time.Text = "10/19/2011 5:30 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Boo McAfee";
                    _subject.Text = "Flash programming, drumming and arcade machines";
                    break;
                case 9 :
                    _time.Text = "9/28/2011 5:00 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Dr. Qi Li";
                    _subject.Text = "Computer vision, graphics, and their relation with AI and gaming";
                    break;
                case 10:
                    _time.Text = "9/12/2011 5:00 P.M.";
                    _location.Text = "SH 2113";
                    _speaker.Text = "Asurion";
                    _subject.Text = "Job and internship opportunities";
                    break;
                case 11 :
                    _time.Text = "4/18/2011 4:30 P.M.";
                    _location.Text = "SH 1101";
                    _speaker.Text = "Dr. Gary";
                    _subject.Text = "IPtable, network file systems, and other topics";
                    break;
                case 12:
                    _time.Text = "2/21/2011 4:30 P.M.";
                    _location.Text = "SH 1108";
                    _speaker.Text = "Dr. Gary";
                    _subject.Text = "UNIX basics";
                    break;
                default:
                    break;
            }
        }
	}
}
