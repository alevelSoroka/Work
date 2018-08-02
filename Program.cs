using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace University
{
    static public class Program
    {
       static Repository _repo = new Repository();
        static public void Main()
        {
          
            do
            {
                Console.WriteLine("Kogo vvodim?: 1 - prepod 2 - stud, 3 - printing, 4 - printing grups");
                var t = Console.ReadLine();
                    switch (t)
                    {
                        case "1":
                            _repo.AddPrepod(Getprepod());
                            break;
                        case "2":
                            var s = GetStud();
                            if(_repo.AddStudent(s))
                                Console.WriteLine("Студент {1} {0} успешно добавлен в одну из существующих груп", s.FirstName, s.Name);
                            else
                                Console.WriteLine("Для студента {1} {0} была создана новая группа", s.FirstName, s.Name);
                            
                            break;
                            Console.WriteLine("Choose 1, 2 or 3");
                            break;
                        case "3":
                            var humans = new List<Human>();
                            humans.AddRange(_repo.GetStudent());
                            humans.AddRange(_repo.GetPrepod());
                            PrintAll(humans);
                        break;
                        case "4":
                        var VseGrups = _repo.GetGrups();
                        int q = 1;
                        Console.WriteLine("Группы: ");
                        foreach (var g in VseGrups)
                        {
                            Console.WriteLine("Группа {0} содержит {1} студентов", q, g.GetStudentCount());
                            
                            q++;
                        }
                        break;

                    }
            }
            while (true);
        }
        static void PrintAll(List<Human> humans)
        {
            Console.WriteLine("Vivod dla {0} elementov", humans.Count);
            foreach (var h in humans)
            {
                Console.WriteLine(h.GetInfo());
            }
        }
        static Student GetStud()
        {
            Console.WriteLine("Добавляем студента:");
            var st = new Student();
            Console.WriteLine("Name:");
            st.Name = Console.ReadLine();
            Console.WriteLine("FirstName:");
            st.FirstName = Console.ReadLine();
            Console.WriteLine("YearOfStartStudy:");
            st.YearOfStartStudy = Console.ReadLine();
            return st;
        }
        static Prepod Getprepod()
        {
            Console.WriteLine("Добавляем препода:");
            var st = new Prepod();
            Console.WriteLine("Name:");
            st.Name = Console.ReadLine();
            Console.WriteLine("FirstName:");
            st.FirstName = Console.ReadLine();
            Console.WriteLine("MainCource:");
            st.MainCource = Console.ReadLine();
            return st;
        }
    }
}

    //public class Human
    //{
    //    string _name;
    //    string _firstName;
    //    string _birthday;


    //    public string Name
    //    {
    //        get
    //        {
    //            return _name;

    //        }
    //        set
    //        {
            
    //            _name = value;
    //        }
    //    }

    //    public string FirstName
    //    {
    //        get
    //        {
    //            return _firstName;

    //        }
    //        set
    //        {
    //            _firstName = value;


    //        }



    //    }
    //    public string Birthday
    //    {
    //        get
    //        {
    //            return _birthday;
    //        }
    //        set
    //        {

    //            _birthday = value;
    //        }

    //    }

    //    public virtual string GetInfo()
    //    {
    //        return string.Format("{0} {1} {2}", _name, _firstName, _birthday);
    //    }
    //}

//public class Student : Human
//{
//    string _yearOfStartStudy;
//    public string YearOfStartStudy
//    {
//        get
//        {
//            return _yearOfStartStudy;
//        }
//        set
//        {

//            _yearOfStartStudy = value;
//        }


//    }

//    public override string GetInfo()
//    {

//        return string.Format("Студент {0} год старта обучения {1}", base.GetInfo(), _yearOfStartStudy);
//    }

//}

//public class Prepod : Human
//{
//    string _mainCource;
//    public string MainCource
//    {
//        get
//        {
//            return _mainCource;
//        }
//        set
//        {

//            _mainCource = value;
//        }

//    }

//    public override string GetInfo()
//    {

//        return string.Format("Препод {0} курс {1}", base.GetInfo(), _mainCource);
//    }
//}


