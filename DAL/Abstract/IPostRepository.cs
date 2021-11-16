using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IPostRepository
    {
        IList<Post> GetPosts();
        void CreatePost(Post post);
    }
}
