using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student : Human
    {
        string _yearOfStartStudy;
        public string YearOfStartStudy
        {
            get
            {
                return _yearOfStartStudy;
            }
            set
            {
                _yearOfStartStudy = value;
            }
        }
        public override string GetInfo()
        {
            return string.Format("Студент {0} год старта обучения {1}", base.GetInfo(), _yearOfStartStudy);
        }
    }
}
