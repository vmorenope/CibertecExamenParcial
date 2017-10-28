using Examen.Models;
using Examen.Repositories.School;

namespace Examen.Repositories.Dapper.School
{
    public class DepartmentsRepository : Repository<Department>, IDepartmentRepository
    {

        public DepartmentsRepository(string connectionString):base(connectionString)
        {
        }
    }
}