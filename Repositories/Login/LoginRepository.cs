using Business;
using DataAccess.Login;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Login
{
    public class LoginRepository : ILoginRepository
    {
        public async Task<int> CheckLogin(LoginModel login)
        {
            using (var db= new MyDbContext())
            {
                var reuslt = db.User.Where(x=>x.Username.Contains(login.UserName) && x.Password.Contains(login.Password)).CountAsync();
                return await reuslt > 0 ? 1 : 0;
            }
        }
    }
}
