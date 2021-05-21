using System;
using Abp.Notifications;
using Afonsoft.Ranking.Dto;

namespace Afonsoft.Ranking.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}