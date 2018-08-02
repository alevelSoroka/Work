using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Repository
    {
        List<GrupStudents> _grups = new List<GrupStudents>();
        List<Prepod> _prepods = new List<Prepod>();

        public bool AddStudent(Student s)
        {
            foreach (var g in _grups)
            {
                if (g.AddStudent(s))
                    return true;
            }
            var grup = new GrupStudents();
            grup.AddStudent(s);
            _grups.Add(grup);
            return false;
        }

        public void AddPrepod(Prepod p)
        {
            _prepods.Add(p);
        }

        public List<Student> GetStudent()
        {
            var students = new List<Student>();
            foreach (var g in _grups)
            {
                students.AddRange(g.GetStudent());

            }
            return students;
        }

        public List<Prepod> GetPrepod()
        {
            return _prepods;
        }

        public List<GrupStudents> GetGrups()
        {
            return _grups;
        }


        
    }
}
