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
        IList<PostDto> GetPosts();
        void CreatePost(global::PostMaker.Controllers.PostDto dto);
    }

    public class PostDto
    {
        public object Created;

        public object Author { get; internal set; }
        public object Id { get; internal set; }
        public object Content { get; internal set; }
    }
}
