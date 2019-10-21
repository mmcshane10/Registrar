using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
    {
        public Course()
        {
            this.Students = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public virtual ICollection<Enrollment> Students { get; set; }
    }
}