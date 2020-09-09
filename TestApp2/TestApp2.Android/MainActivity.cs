using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using TestApp2.Entities;
using Adapter = TestApp2.Android.adapter.Adapter;

namespace TestApp2.Android{
    [Activity(Label = "TestApp2", MainLauncher = true)]
    public class MainActivity : Activity{
        private Adapter adapter = null!;
        private ProgressBar progressBar = null!;
        private readonly Data data = new Data();

        private readonly Action<Beer> click;

        public MainActivity(){
            click = beer => {
                var intent = new Intent(this, typeof(SecondActivity));
                intent.PutExtra("beer_id", beer.id.ToString());
                intent.SetFlags(ActivityFlags.ClearTop);
                StartActivity(intent);
            };
        }

        protected override void OnCreate(Bundle savedInstanceState){
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            progressBar = FindViewById<ProgressBar>(Resource.Id.progressBar)!;
            getData();
        }
        
        private async Task getData(){
            try{ 
                var result = await data.GetAllBeer();
                adapter = new Adapter(result, click);
                var recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
                recyclerView?.SetLayoutManager(new LinearLayoutManager(this));
                recyclerView?.SetAdapter(adapter);
            }
            catch (Exception e){
                Toast.MakeText(this, "Error loading", ToastLength.Short).Show();
                Log.Error("ERROR", e.Message);
                throw;
            }
            progressBar.Visibility = ViewStates.Gone;
        }
    }
}