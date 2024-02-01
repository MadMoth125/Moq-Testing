using Moq;
using NotificationSystem.Classes;
using NotificationSystem.Interfaces;

namespace Moq_Mock
{
	/*
	 * 
	 */
	public class NotificantionServicesTests
	{
		[Fact]
		public void NotificantionServices_SendBirthdayGreetings()
		{
			// Arrange
			var notifSenderMock = new Mock<INotifSender>();
			var notificationService = new NotificationService(notifSenderMock.Object);
			string recipient = "john.j.james@gmail.com";

			// Act
			notificationService.SendBirthdayGreetings(recipient);

			// Assert
			notifSenderMock.Verify(x => x.SendNotification("Happy Birthday!", recipient), Times.Once);
		}

		[Fact]
		public void NotificantionServices_SendMeetingReminder()
		{
			// Arrange
			var notifSenderMock = new Mock<INotifSender>();
			var notificationService = new NotificationService(notifSenderMock.Object);
			string recipient = "employee@hotmail.com";

			// Act
			notificationService.SendMeetingReminder(recipient);

			// Assert
			notifSenderMock.Verify(x => x.SendNotification("Meeting in 15 minutes", recipient), Times.Once);
		}

		[Fact]
		public void NotificantionServices_NotifyUser()
		{
			// Arrange
			var notifSenderMock = new Mock<INotifSender>();
			var notificationService = new NotificationService(notifSenderMock.Object);
			string recipient = "(405)-123-4567";

			// Act
			notificationService.NotifyUser("Hey there bud!", recipient);

			// Assert
			notifSenderMock.Verify(x => x.SendNotification("Hey there bud!", recipient), Times.Once);
		}
	}
}