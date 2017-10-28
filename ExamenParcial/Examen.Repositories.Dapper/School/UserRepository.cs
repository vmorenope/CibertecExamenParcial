using Dapper;
using Examen.Models;
using Examen.Repositories.School;
using System.Data.SqlClient;

namespace Examen.Repositories.Dapper.School
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(string connectionString) : base(connectionString)
        {
        }

        public User ValidaterUser(string email, string passwork)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@email", email);
                parameters.Add("@password", passwork);

                return connection.QueryFirst<User>(
                    "dbo.ValidateUser",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
