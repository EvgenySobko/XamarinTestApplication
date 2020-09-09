using System;
using System.Threading.Tasks;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Util;
using Square.Picasso;

namespace TestApp2.Android{
    
    [Activity(Label = "TestApp2", MainLauncher = false)]
    public class SecondActivity : Activity{
        
        private readonly Data data = new Data();
        private int beerId;
        
        protected override void OnCreate(Bundle savedInstanceState){
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_second);
            beerId = int.Parse(Intent.GetStringExtra("beer_id"));
            Log.Debug("ERROR", beerId.ToString());
            getBeer();
        }

        private async Task getBeer(){
            try{
                var result = await data.GetBeerById(beerId);
                var title = (TextView) FindViewById(Resource.Id.title)!;
                var description = (TextView) FindViewById(Resource.Id.description)!;
                var image = (ImageView) FindViewById(Resource.Id.image)!;
                
                Picasso.Get()
                    .Load(result[0].image_url)
                    .Placeholder(Resource.Drawable.beer_placeholder)
                    .Into(image);
                title.Text = result[0].name + ", " + result[0].ph + "%";;
                description.Text = result[0].description;
            }
            catch (Exception e){
                Toast.MakeText(this, "Error loading", ToastLength.Short).Show();
                Log.Debug("ERROR", e.Message);
                throw;
            }
        }
    }
}