using System;
using System.Collections.Generic;
using DevopsLearn.Models;

namespace DevopsLearn.Repository
{
    public interface IPostRepository
    {
        List<PostViewModel> GetPosts();
    }
}
