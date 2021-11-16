using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APSWebMCV.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public float Note1 { get; set; }
        public float Note2 { get; set; }
        public float FinalExamNote { get; set; }
        public int Frequency { get; set; }

        public Professor Professor { get; set; }

        public Assessment()
        {

        }

        public Assessment(int id, float note1, float note2, float finalExamNote, int frequency, Professor professor)
        {
            Id = id;
            Note1 = note1;
            Note2 = note2;
            FinalExamNote = finalExamNote;
            Frequency = frequency;
            Professor = professor;
        }
    }
}
