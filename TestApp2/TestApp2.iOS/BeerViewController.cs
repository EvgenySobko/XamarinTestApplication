using Android.Util;
using Foundation;
using System;
using System.Collections.Generic;using System.Diagnostics;using System.Threading.Tasks;using TestApp2.Entities;using UIKit;namespace TestApp2.iOS
{
    public partial class BeerViewController : UITableViewController
    {

        List<Beer> list = new List<Beer>();

        public BeerViewController(IntPtr handle) : base(handle)        {            GetData();        }

        public override nint NumberOfSections(UITableView tableView)        {            return 1;        }

        public override nint RowsInSection(UITableView tableView, nint section)        {            return list.Count;        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)        {            var cell = tableView.DequeueReusableCell("Beer") as BeerCell;            var data = list[indexPath.Row];            cell.beerData = data;            return cell;        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)        {            var controller = this.Storyboard.InstantiateViewController("Description") as DescriptionViewController;            this.NavigationController.PushViewController(controller, true);        }

        public async Task GetData()        {            try            {                list.AddRange(await new Data().GetAllBeer());                MyTable.ReloadData();            }            catch (Exception e){                Console.WriteLine(e.ToString());            }        }
    }
}