using Examen.Repositories.School;

namespace Examen.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICourseRepository Courses { get; }
        IDepartmentRepository Departments { get; }
        IPersonRepository Persons { get; }
        IStudentGradeRepository Students { get; }
        IUserRepository Users { get; }
    }
}
