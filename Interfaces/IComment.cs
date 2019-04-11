
using blog.Models;

namespace blog.Interfaces{
    public interface IComment{
        void AddComment(string commentFullName,string commentMail,string commentContent,int articleId);
    }
}