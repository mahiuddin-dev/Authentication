using Authentication.Models;
using EF.Core.Repository.Interface.Manager;

namespace Authentication.Interfaces.Manager
{
    public interface IUserManager : ICommonManager<UserAuthentication>
    {
        UserAuthentication GetById(int id);
    }
}
