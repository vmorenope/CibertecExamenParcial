using Examen.Models;
using Examen.Repositories.School;

namespace Examen.Repositories.Dapper.School
{
    public class CoursesRepository : Repository<Course>, ICourseRepository
    {

        public CoursesRepository(string connectionString):base(connectionString)
        {

        }
    }
}