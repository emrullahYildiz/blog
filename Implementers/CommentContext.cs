
using System;
using blog.Interfaces;
using blog.Models;

namespace blog.Implementers{
    public class CommentContext : IComment
    {
        private readonly DatabaseContext databaseContext;
        public CommentContext(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public void AddComment(string commentFullName,string commentMail,string commentContent,int articleId)
        {
            DateTime commentDateTime = DateTime.Now;
            Comment comment = new Comment{
                ArticleID = articleId,
                CommentFullname = commentFullName,
                CommentMail = commentMail,
                CommentContent = commentContent,
                CommentDate = commentDateTime
            };
            databaseContext.Comments.Add(comment);
            databaseContext.SaveChanges();
        }
    }
}