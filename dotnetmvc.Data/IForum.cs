﻿using dotnetmvc.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnetmvc.Data
{
    public interface IForum
    {
        Forum GetByID(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers();

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);

    }
}
