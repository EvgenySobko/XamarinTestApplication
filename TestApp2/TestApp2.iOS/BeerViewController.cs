using Android.Util;
using Foundation;
using System;
using System.Collections.Generic;
{
    public partial class BeerViewController : UITableViewController
    {

        List<Beer> list = new List<Beer>();

        public BeerViewController(IntPtr handle) : base(handle)

        public override nint NumberOfSections(UITableView tableView)

        public override nint RowsInSection(UITableView tableView, nint section)

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)

        public async Task GetData()
    }
}