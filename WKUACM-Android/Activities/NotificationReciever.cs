using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WKUACM.Activities;

namespace WKUACM
{
	class NotificationReciever : BroadcastReceiver
    {
		public override void OnReceive(Context context, Intent intent)
		{
			PowerManager powerManager = (PowerManager)context.GetSystemService(Context.PowerService);
			PowerManager.WakeLock wakeLock = powerManager.NewWakeLock(WakeLockFlags.Partial, "Notification Reciever");
			wakeLock.Acquire();

			var notificationManager = (NotificationManager)context.GetSystemService(Context.NotificationService);
			var notification = new Notification(Resource.Drawable.Icon, "New Meeting");
			var pendingIntent = PendingIntent.GetActivity(context, 0, new Intent(context, typeof(SplashScreenActivity)), 0);
			notification.SetLatestEventInfo(context, "New Meeting", "There is an ACM meeting today.", pendingIntent);
			notificationManager.Notify(0, notification);
			wakeLock.Release();
		}

		public void CancelAlarm(Context context)
		{
			Intent intent = new Intent(context, this.Class);
			PendingIntent sender = PendingIntent.GetBroadcast(context, 0, intent, 0);
			AlarmManager alarmManager = (AlarmManager)context.GetSystemService(Context.AlarmService);
			alarmManager.Cancel(sender);
		}

		public void SetAlarm(Context context, int alertTime)
		{
			long now = SystemClock.CurrentThreadTimeMillis();
			AlarmManager alarmManager = (AlarmManager)context.GetSystemService(Context.AlarmService);
			Intent intent = new Intent(context, this.Class);
			PendingIntent pendingIntent = PendingIntent.GetBroadcast(context, 0, intent, 0);
			alarmManager.Set(AlarmType.ElapsedRealtimeWakeup, now + ((long)(alertTime * 100)), pendingIntent);
		}
    }
}

