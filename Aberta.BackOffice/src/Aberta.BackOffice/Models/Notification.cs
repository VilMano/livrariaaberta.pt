using Syncfusion.Blazor.Notifications;

namespace AbertaBackOffice.Models;

public class Notification
{
    public string Title { get; set; }
    public string Content { get; set; }
    public MessageSeverity Severity { get; set; }
}