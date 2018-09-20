using SBSA.OffShore.Domain.EventStore.Events;
using System;

namespace SBSA.OffShore.Domain.Item
{
    public class CommentItem: AggregateRoot,
        IHandle<CommentAddedEvent>
    {
        public CommentItem(int commentKey, int adaptivReconId, string reference, string reconStatus, 
            string comments, string username, DateTime businessDate, DateTime? commentDate)
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
        public int AdaptivReconId { get; set; }
        public string Reference { get; set; }
        public string ReconStatus { get; set; }
        public string Comments { get; set; }
        public string Username { get; set; }
        public DateTime BusinessDate { get; set; }
        public DateTime? CommentDate { get; set; }

        public void Handle(CommentAddedEvent e)
        {
            throw new NotImplementedException();
        }
    }

}
