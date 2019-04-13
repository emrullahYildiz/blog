
using System.Collections.Generic;
using blog.Models;

namespace blog.Interfaces{
    public interface IComment{
        void AddComment(string commentFullName,string commentMail,string commentContent,int articleId);
        List<Comment> getLastComments();
        void DeleteCommentById(int id);

        List<Comment> SearchCommentByArticleHead(string articleHead);

    }
}