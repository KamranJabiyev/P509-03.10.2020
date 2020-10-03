using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    partial class Person
    {
        public string Fullname()
        {
            return $"{Name} {Surname}";
        }

        public virtual string FullInfo()
        {
            return $"{Fullname()} {Age}";
        }
    }
}
