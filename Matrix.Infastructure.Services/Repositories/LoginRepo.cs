using Matrix.Core.Application.DTOs;
using Matrix.Core.Application.Interfaces;
using Matrix.Infastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix.Infastructure.Services.Repositories
{
    public class LoginRepo : ILoginRepo
    {
        private MatrixContext _context;
        public LoginRepo(MatrixContext context)
        {
                _context = context;
        }

        public async Task<bool> LoginUser(LoginDTO req)
        {
            try
            {
                var isExist = _context.Users.Where(x => x.UserLoginID == req.UserLoginID).FirstOrDefault();
                if (isExist != null)
                {
                    if (isExist.UserPassword == req.UserPassword)
                    {
                        throw new Exception("Login Successful");
                    }
                    else
                    {
                        throw new Exception("User Not Authorized!");
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
                return true;

        }
    }
}
