using DataAccess.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Login
{
    public interface ILoginRepository
    {
        Task<int> CheckLogin(LoginModel login);
    }
}
