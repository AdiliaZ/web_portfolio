﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortfolio.Models;

namespace WebPortfolio.Data.Repository
{
    public interface IRepository
    {
       Post GetPost(int id);
        List<Post> GetAllPost();
        void AddPost(Post post);
        void UpdatePost(Post post);
        void RemovePost(int id);

        Task<bool> SaveChangesAsync();
    }
}
