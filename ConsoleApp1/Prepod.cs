using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Prepod : Human
    {
        string _mainCource;
        public string MainCource
        {
            get
            {
                return _mainCource;
            }
            set
            {
                _mainCource = value;
            }
        }
        public override string GetInfo()
        {
            return string.Format("{0} {1}", base.GetInfo(), _mainCource);
        }
    }
}
