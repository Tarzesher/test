using SBSA.Recon.Tool.Application.DataTransferObject;
using SBSA.Recon.Tool.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SBSA.Recon.Tool.WebApiTest
{
    public class CommentsTest
    {
        [Fact]
        public void CreateComment()
        {
            var newComment = new CommentDto
            {
                ApplyToAll = false,
                AdaptivReconId = 11,
                BusinessDate = DateTime.Now,
                CommentDate = DateTime.Now,
                Comments = "Test Single comments2",
                ReconStatus = "Items in Source",
                Reference = "M589213000"
            };

            var commentsController = new CommentController();

            //Assign
            commentsController.CreateComments(newComment);
        }

        [Fact]
        public void CreateCommentForAllRecords()
        {
            var newComment = new CommentDto
            {
                ApplyToAll = true,
                AdaptivReconId = 10,
                BusinessDate = DateTime.Now,
                CommentDate = DateTime.Now,
                Comments = "Test Single comments",
                ReconStatus = "Items in Source",
            };

            var commentsController = new CommentController();

            //Assign
            commentsController.CreateComments(newComment);
        }
    }
}
