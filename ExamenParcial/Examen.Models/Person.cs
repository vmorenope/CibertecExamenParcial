using System;
using Dapper.Contrib.Extensions;

namespace Examen.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
