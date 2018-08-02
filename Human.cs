using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class Human
        {
            string _name;
            string _firstName;
            DateTime _birthday;
            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public string FirstName
            {
                get
                {
                    return _firstName;
                }
                set
                {
                    _firstName = value;
                }
            }
            public DateTime Birthday
            {
                get
                {
                    return _birthday;
                }
                set
                {
                    _birthday = value;
                }
            }
            public virtual string GetInfo()
            {
                return string.Format("{0} {1} {2}", _name, _firstName, _birthday);
            }
        }
    
}
