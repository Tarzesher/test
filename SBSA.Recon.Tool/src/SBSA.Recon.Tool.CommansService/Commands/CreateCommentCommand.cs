using SBSA.Recon.Tool.CommandService;
using System;

namespace SBSA.OffShore.CommandService.Commands
{
    public class CreateCommentCommand : Command
    {
        public CreateCommentCommand(int id, string adaptivReconId, string reference, 
            string reconStatus, string comments, string username, string businessDate, DateTime? commentDate) : base(id, -1)
        {
            Id = id;
            AdaptivReconId = adaptivReconId;
            Reference = reference;
            ReconStatus = reconStatus;
            Comments = comments;
            Username = username;
            BusinessDate = businessDate;
            CommentDate = commentDate;
        }

        public int Id { get; set; }
        public string AdaptivReconId { get; set; }
        public string Reference { get; set; }
        public string ReconStatus { get; set; }
        public string Comments { get; set; }
        public string Username { get; set; }
        public string BusinessDate { get; set; }
        public DateTime? CommentDate { get; set; }
    }
}
