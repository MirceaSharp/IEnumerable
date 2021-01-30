using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myStudents = new List<string>();
            myStudents.Add("Mircea");
            Classroom myClassroom = new Classroom(myStudents);
            Console.WriteLine(myClassroom.Students.First());
            Console.ReadLine();
        }
    }
}
