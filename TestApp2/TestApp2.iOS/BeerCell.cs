using FFImageLoading;
using Foundation;
using System;
using TestApp2.Entities;using UIKit;

namespace TestApp2.iOS
{
    public partial class BeerCell : UITableViewCell
    {
        private Beer beer;

        public Beer beerData        {            get { return beer; }            set            {                beer = value;                BeerNameLabel.Text = beer.name;                ImageService.Instance.LoadUrl(beer.image_url).Into(BeerImage);            }        }
        public BeerCell (IntPtr handle) : base (handle)
        {
        }
    }
}