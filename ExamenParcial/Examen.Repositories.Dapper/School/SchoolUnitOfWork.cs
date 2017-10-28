using Examen.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using Examen.Repositories.School;

namespace Examen.Repositories.Dapper.School
{
    public class SchoolUnitOfWork : IUnitOfWork
    {
        public SchoolUnitOfWork(string connectionString)
        {
            Courses = new CoursesRepository(connectionString);
            Departments = new DepartmentsRepository(connectionString);
            Persons = new PersonsRepository(connectionString);
            Students = new StudentsRepository(connectionString);
        }

        public ICourseRepository Courses { get; private set; }
        public IDepartmentRepository Departments { get; private set; }
        public IPersonRepository Persons { get; private set; }
        public IStudentGradeRepository Students { get; private set; }
    }
}
