﻿using Dapper.Contrib.Extensions;
namespace Examen.Models
{
    public class StudentGrade
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public decimal Grade { get; set; }
    }
}
