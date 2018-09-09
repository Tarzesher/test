using SBSA.OffShore.Domain.EventStore.Events;
using System;

namespace SBSA.OffShore.Domain.Item
{
    public class CommentItem: AggregateRoot,
        IHandle<CommentAddedEvent>
    {
        public CommentItem(int commentKey, string adaptivReconId, string reference, string reconStatus, 
            string comments, string username, string businessDate, DateTime? commentDate)
        {
            CommentKey = commentKey;
            AdaptivReconId = adaptivReconId;
            Reference = reference;
            ReconStatus = reconStatus;
            Comments = comments;
            Username = username;
            BusinessDate = businessDate;
            CommentDate = commentDate;
        }

        public int CommentKey { get; set; }
        public string AdaptivReconId { get; set; }
        public string Reference { get; set; }
        public string ReconStatus { get; set; }
        public string Comments { get; set; }
        public string Username { get; set; }
        public string BusinessDate { get; set; }
        public DateTime? CommentDate { get; set; }

        public void Handle(CommentAddedEvent e)
        {
            throw new NotImplementedException();
        }
    }

}
