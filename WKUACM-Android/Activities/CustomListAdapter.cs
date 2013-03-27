using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;
using Android.Views;

namespace WKUACM
{
	public class CustomListAdapter : BaseAdapter<TableItem>
	{
		List<TableItem> items;
		Activity context;

		public CustomListAdapter (Activity context, List<TableItem> items)
			:base ()
		{
			this.context = context;
			this.items = items;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override TableItem this[int position]
		{
			get { return items[position]; }
		}

		public override int Count
		{
			get { return items.Count; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			
			View view = convertView;
			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.CustomView, null);
			view.FindViewById<TextView>(Resource.Id.Date).Text = item.Date;
			view.FindViewById<TextView>(Resource.Id.Location).Text = item.Location;
			view.FindViewById<TextView>(Resource.Id.Speaker).Text = item.Speaker;
			view.FindViewById<TextView>(Resource.Id.Description).Text = item.Description;
			view.LayoutParameters = new ListView.LayoutParams(ViewGroup.LayoutParams.FillParent, 160);
			return view;
		}
	}
}