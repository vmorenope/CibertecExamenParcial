using Examen.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Repositories.School
{
    public interface IUserRepository:IRepository<User>
    {
        User ValidaterUser(string email, string passwork);
    }
}
