using System.Collections.Generic;

namespace Registrar.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Enrollment>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public virtual ApplicationUser User { get; set; } //new line

        public ICollection<Enrollment> Courses { get; }
    }
}