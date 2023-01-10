using Authentication.Context;
using Authentication.Interfaces.Manager;
using Authentication.Models;
using Authentication.Repository;
using EF.Core.Repository.Manager;

namespace Authentication.Manager
{
    public class UserManager : CommonManager<UserAuthentication>, IUserManager
    {
        public UserManager(ApplicationDbContext _dbContext) : base(new UserRepository(_dbContext))
        {
        }

        public UserAuthentication GetById(int id)
        {
            return GetFirstOrDefault(x => x.Id == id);
        }
    }
}
