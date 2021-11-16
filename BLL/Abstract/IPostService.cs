using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContract;

namespace BLL.Abstract
{
    public  interface IPostService
    {
        IList<PostDTO> GetPosts();
        void CreatePost(PostDTO post);
    }
}
