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
            _table.Source = new TableSource(this);

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

            _table.ReloadData();
        }

        private class TableSource : UITableViewSource
        {
            private const string CellName = "MainCell";
            
            public TableSource (MainViewController controller)
            {
                
            }
            
            public override int RowsInSection (UITableView tableview, int section)
            {
                return 13;
            }
            
            public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(CellName) as MainCell;
              
                if (cell != null)
                {
                    cell.Update (indexPath);
                }
                return cell;
            }
            
            public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.CellAt (indexPath);
                cell.SetSelected (false, true);
            }
        }
    }
}

