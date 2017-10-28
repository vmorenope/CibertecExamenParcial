using Examen.Models;
using Examen.Repositories.School;

namespace Examen.Repositories.Dapper.School
{
    public class PersonsRepository : Repository<Person>, IPersonRepository
    {

        public PersonsRepository(string connectionString):base(connectionString)
        {
        }
    }
}