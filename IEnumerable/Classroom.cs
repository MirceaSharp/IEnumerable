using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Classroom
    {
        public IEnumerable<string> Students
        {
            get; private set;
        }
        public Classroom(List<string> students)
        {
            this.Students = students;

        }

    }
}
