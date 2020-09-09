using FFImageLoading;
using Foundation;
using System;
using System.Threading.Tasks;using TestApp2.Entities;using UIKit;

namespace TestApp2.iOS
{
    public partial class DescriptionViewController : UIViewController
    {

        private Beer beer;

        public DescriptionViewController (IntPtr handle) : base(handle)
        {
            //_ = GetDataById(id);
                                                  
        }

        private async Task GetDataById(int id)        {            var result = await new Data().GetBeerById(id);            beer = result[0];            Console.WriteLine(beer.ToString());            ImageService.Instance.LoadUrl(beer.image_url).Into(BeerImageLarge);         }
    }
}