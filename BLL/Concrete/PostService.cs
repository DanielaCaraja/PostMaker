﻿using BLL.Abstract;
using DAL.Abstract;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            {
                _postRepository = postRepository;
            }
        }
        public object Author;
        public object Content;
        public object Created;
        public object Id;

        public void CreatePost(PostDto dto)
        {
            var post = new Post();
            {
                Author = dto.Author;
                Content = dto.Content;//Replace("\n", "<br />");
                    Created = dto.Created;
                Id = dto.Id;
            };

            _postRepository.CreatePost(post);

        }

        public IList<PostDto> GetPosts()
        {
            var posts = _postRepository.GetPosts();
            var dtos = posts.Select(x => new PostDto()
            {
                Author = x.Author,
                Content = x.Content,
                Created = x.Created,
                Id = x.Id

            }).ToList();
            return dtos;

        }
    }
}
