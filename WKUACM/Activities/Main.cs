using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace WKUACM
{
    [Activity(Label = "Main Activity")]
    public class Main : Activity
    {
		List<TableItem> tableItems = new List<TableItem>();
		ListView listView;
	
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			
			SetContentView(Resource.Layout.Main);
			listView = FindViewById<ListView>(Resource.Id.listView1);

			TextView UrlText = (TextView) FindViewById(Resource.Id.ACMWebSite);
			UrlText.Click += (sender, e) => 
			{
				var intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse(UrlText.Text));
				StartActivity(intent);
			};
			
			tableItems.Add(new TableItem() { Date = "11/4/1991", Location = "Snell 1102", Speaker = "Bob", Description = "Presentation on android development" });
			tableItems.Add(new TableItem() { Date = "11/4/1991", Location = "Snell 1102", Speaker = "Bob", Description = "Presentation on android development" });
			tableItems.Add(new TableItem() { Date = "11/4/1991", Location = "Snell 1102", Speaker = "Bob", Description = "Presentation on android development" });
			tableItems.Add(new TableItem() { Date = "11/4/1991", Location = "Snell 1102", Speaker = "Bob", Description = "Presentation on android development" });
			tableItems.Add(new TableItem() { Date = "11/4/1991", Location = "Snell 1102", Speaker = "Bob", Description = "Presentation on android development" });
			tableItems.Add(new TableItem() { Date = "11/4/1991", Location = "Snell 1102", Speaker = "Bob", Description = "Presentation on android development" });
			
			listView.Adapter = new CustomListAdapter(this, tableItems);
			
			listView.ItemClick += OnListItemClick;
		}

		protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
		{
			var listView = sender as ListView;
			var t = tableItems[e.Position];
		}
    }
}

