
using System;
using System.Collections.Generic;
using System.Linq;
using blog.Interfaces;
using blog.Models;
using Microsoft.EntityFrameworkCore;

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

        public void DeleteCommentById(int id)
        {
            Comment comment = databaseContext.Comments.SingleOrDefault(q => q.CommentID == id);
            databaseContext.Comments.Remove(comment);
            databaseContext.SaveChanges();
        }

        public List<Comment> getLastComments()
        {
            List<Comment> comments;
            try{
                comments = databaseContext.Comments.Include(q => q.Article).OrderByDescending(q=>q.CommentDate).Take(10).ToList();
            }catch{
                comments = databaseContext.Comments.Include(q => q.Article).ToList();//if count less then 10, take all comment
            }
            return comments;
        }

        public List<Comment> SearchCommentByArticleHead(string articleHead)
        {
            List<Comment> comments;
            comments = databaseContext.Comments.Include(q => q.Article)
                                      .Where(q => q.Article.ArticleHead.Contains(articleHead)).ToList();
            return comments;
        }
    }
}