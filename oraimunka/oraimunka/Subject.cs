using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraimunka
{
    public class Subject
    {
        public int Credit { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool HasExam { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
