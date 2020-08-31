using System;
using System.Collections.Generic;
using Android;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Util;
using Android.Views;
using Android.Widget;
using Square.Picasso;
using TestApp2.Entities;

namespace TestApp.adapter{
    public class Adapter: RecyclerView.Adapter {
        
        private List<Beer> listOfItems;
        private static Action<Beer> clickListener;
        
        public Adapter (List<Beer> list, Action<Beer> click){
            listOfItems = list;
            clickListener = click;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType){
            return new ViewHolder(LayoutInflater.From(parent.Context)?
                .Inflate(TestApp2.Android.Resource.Layout.item_fact_list, parent, false)!);
        }
        
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position){
            (holder as ViewHolder)?.bind(listOfItems[position]);
        }

        public override int ItemCount => listOfItems.Count;

        class ViewHolder : RecyclerView.ViewHolder {
            
            public ViewHolder(View itemView) : base(itemView){ }

            public void bind(Beer item){
                var title = ItemView.FindViewById<TextView>(TestApp2.Android.Resource.Id.title);
                var clickable = ItemView.FindViewById(TestApp2.Android.Resource.Id.clickable);
                var image = (ImageView) ItemView.FindViewById(TestApp2.Android.Resource.Id.image)!;

                clickable!.Click += (sender, e) => { clickListener.Invoke(item); };
                title!.Text = item.name;
                Picasso.Get()
                    .Load(item.image_url)
                    .Into(image);
            }
        }
    }
}