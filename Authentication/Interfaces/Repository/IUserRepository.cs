using Authentication.Models;
using EF.Core.Repository.Interface.Repository;

namespace Authentication.Interfaces.Repository
{
    public interface IUserRepository : ICommonRepository<UserAuthentication>
    {
    }
}
