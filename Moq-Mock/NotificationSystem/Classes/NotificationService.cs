using NotificationSystem.Interfaces;

namespace NotificationSystem.Classes
{
	public class NotificationService
	{
		private readonly INotifSender _notifSender;

		public NotificationService(INotifSender notifSender)
		{
			_notifSender = notifSender;
		}

		public void NotifyUser(string message, string recipient)
		{
			_notifSender.SendNotification(message, recipient);
		}

		public void SendBirthdayGreetings(string recipient)
		{
			string birthdayMessage = "Happy Birthday!";
			_notifSender.SendNotification(birthdayMessage, recipient);
		}

		public void SendMeetingReminder(string recipient)
		{
			string meetingReminder = "Meeting in 15 minutes";
			_notifSender.SendNotification(meetingReminder, recipient);
		}
	}
}