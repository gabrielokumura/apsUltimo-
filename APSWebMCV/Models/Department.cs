using System.Collections.Generic;

namespace APSWebMCV.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Professor> Professors { get; set; } = new List<Professor>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddProfessor(Professor professor)
        {
            Professors.Add(professor);
        }
    }
}
