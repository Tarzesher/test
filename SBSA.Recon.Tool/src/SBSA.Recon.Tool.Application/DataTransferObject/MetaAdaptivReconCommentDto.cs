using System;

namespace SBSA.Recon.Tool.Application.DataTransferObject
{
    public class MetaAdaptivReconCommentDto 
    {
        public int CommentKey { get; set; }
        public string AdaptivReconId { get; set; }
        public string Reference { get; set; }
        public string ReconStatus { get; set; }
        public string Comments { get; set; }
        public string Username { get; set; }
        public string BusinessDate { get; set; }
        public DateTime? CommentDate { get; set; }
    }
}
