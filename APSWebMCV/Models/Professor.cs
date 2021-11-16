using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace APSWebMCV.Models
{
    public class Professor : People
    {
        public string Titulation { get; set; }
        public Department Department { get; set; }

        public ICollection<Assessment> Assessments { get; set; } = new List<Assessment>();

        public Professor()
        {

        }

        public Professor(string titulation, Department department) 
        {
            Titulation = titulation;
            Department = department;
        }

        public void AddAssessment(Assessment assessment)
        {
            Assessments.Add(assessment);
        }

        public void RemoveAssessment(Assessment assessment)
        {
            Assessments.Remove(assessment);
        }
    }
}
