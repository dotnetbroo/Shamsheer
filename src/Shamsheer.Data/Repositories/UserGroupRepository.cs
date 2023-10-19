﻿using Shamsheer.Data.DbContexts;
using Shamsheer.Data.IRepositories;
using Shamsheer.Domain.Entities.Chats;

namespace Shamsheer.Data.Repositories;

public class UserGroupRepository : Repository<UserGroup>, IUserGroupRepository
{
    public UserGroupRepository(ShamsheerDbContext dbContext) : base(dbContext)
    {
    }
}
