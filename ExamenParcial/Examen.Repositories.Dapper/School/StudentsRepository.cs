using Examen.Models;
using Examen.Repositories.School;

namespace Examen.Repositories.Dapper.School
{
    public class StudentsRepository : Repository<StudentGrade>, IStudentGradeRepository
    {
        public StudentsRepository(string connectionString):base(connectionString)
        {
        }
    }
}