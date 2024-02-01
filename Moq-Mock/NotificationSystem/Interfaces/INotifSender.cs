namespace NotificationSystem.Interfaces
{
	public interface INotifSender
	{
		public void SendNotification(string message, string recipient);
	}
}
