using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GrupStudents
    {
        List<Student> _students = new List<Student>();

        public bool AddStudent(Student s)
        {
            if (_students.Count >= MaxCount)
                return false;
            _students.Add(s);
            return true;
        }

        public List<Student> GetStudent()
        {
            return _students;
        }

        public int GetStudentCount()
        {

            return _students.Count;
        }

        int MaxCount = 2;
    }
}
