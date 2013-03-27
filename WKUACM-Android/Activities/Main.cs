﻿using System;
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
			
			tableItems.Add(new TableItem() { Date = "3/27/2013 5:00 P.M.", Location = "SH 1102", Speaker = "Dr. Wang", Description = "Presentation on data mining" });
			tableItems.Add(new TableItem() { Date = "2/20/2013 5:00 P.M.", Location = "SH 1101", Speaker = "Mike Maddox", Description = "Introduction of Fiserv" });
			tableItems.Add(new TableItem() { Date = "11/28/2012 5:00 P.M.", Location = "SH 1101", Speaker = "Jon Peppers", Description = "Talk on Xamarin mobile development" });
			tableItems.Add(new TableItem() { Date = "10/24/2012 5:00 P.M.", Location = "SH 1101", Speaker = "Dr. Ziegler", Description = "Presentation on android development" });
			tableItems.Add(new TableItem() { Date = "9/26/2012 4:45 P.M.", Location = "SH 1101", Speaker = "Dr. Qi Li", Description = "Agenda discussion" });
			tableItems.Add(new TableItem() { Date = "3/19/2012 4:30 P.M.", Location = "SH 1101", Speaker = "Jon Peppers", Description = "Hitcents developer" });
			tableItems.Add(new TableItem() { Date = "2/6/2012 4:30 P.M.", Location = "SH 1101", Speaker = "Local Company", Description = "Company job opportunities" });
			tableItems.Add(new TableItem() { Date = "11/16/2011 5:00 P.M.", Location = "SH 1101", Speaker = "Dr. Gary", Description = "Parallel Programming with MPI" });
			tableItems.Add(new TableItem() { Date = "10/19/2011 5:30 P.M.", Location = "SH 1101", Speaker = "Boo McAfee", Description = "Flash programming, drumming and arcade machines" });
			tableItems.Add(new TableItem() { Date = "9/28/2011 5:00 P.M.", Location = "SH 1101", Speaker = "Dr. Qi Li", Description = "Computer vision, graphics, and their relation with AI and gaming" });
			tableItems.Add(new TableItem() { Date = "9/12/2011 5:00 P.M.", Location = "SH 2113", Speaker = "Asurion", Description = "Job and internship opportunities" });
			tableItems.Add(new TableItem() { Date = "4/18/2011 4:30 P.M.", Location = "SH 1101", Speaker = "Dr. Gary", Description = "IPtable, network file systems, and other topics" });
			tableItems.Add(new TableItem() { Date = "2/21/2011 4:30 P.M.", Location = "SH 1108", Speaker = "Dr. Gary", Description = "UNIX basics" });


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
