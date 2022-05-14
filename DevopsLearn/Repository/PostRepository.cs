using System;
using System.Collections.Generic;
using DevopsLearn.Models;

namespace DevopsLearn.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel>
            {
                new PostViewModel(){PostId=101,Title="Devops Demo1",Description="Description",Author="Gaurav"},
                new PostViewModel(){PostId=102,Title="Devops Demo2",Description="Description Second",Author="Bira"}
            };

            return posts;
        }
    }
}
