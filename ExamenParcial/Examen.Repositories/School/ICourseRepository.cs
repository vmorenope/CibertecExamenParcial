using Examen.Models;

namespace Examen.Repositories.School
{
    public interface ICourseRepository:IRepository<Course>
    {
        ICourseRepository Courses { get; }
        IDepartmentRepository Departments { get; }
        IPersonRepository Persons { get; }
        IStudentGradeRepository Students { get; }
    }
}
