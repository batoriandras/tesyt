using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraimunka
{
    public class Student
    {
        public string Name { get; set; }
        public string NeptunCode { get; set; }
        public int BirthYear { get; set; }
        public int EnrollmentYear { get; set; }
        public int CompletedCredits { get; set; }
        public List<Subject> Subjects { get; set; }
        public bool Absolved { get; set; }
        public bool Graduated { get; set; }
    }
}
