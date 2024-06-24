using CQRS.Core.Events;

namespace Post.Common.Events;

public class CommentEditedCommand : BaseEvent
{
    public CommentEditedCommand() : base(nameof(CommentEditedCommand))
    {
    }

    public Guid CommentId { get; set; }
    public string Comment { get; set; }
    public string UserName { get; set; }
    public DateTime CommentDate { get; set; }
    
}