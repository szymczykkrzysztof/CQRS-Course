using CQRS.Core.Events;

namespace Post.Common.Events;

public class CommentUpdatedCommand : BaseEvent
{
    public CommentUpdatedCommand() : base(nameof(CommentUpdatedCommand))
    {
    }

    public Guid CommentId { get; set; }
    public string Comment { get; set; }
    public string UserName { get; set; }
    public DateTime EditDate { get; set; }
}