using Authentication.Context;
using Authentication.Interfaces.Repository;
using Authentication.Models;
using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;

namespace Authentication.Repository
{
    public class UserRepository : CommonRepository<UserAuthentication>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
