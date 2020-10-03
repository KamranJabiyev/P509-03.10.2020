using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    class Developer:Person
    {
        public Developer(string name,string surname,int age,int exprience):base(name,surname,age)
        {
            Experience = exprience;
            Knowledge = new string[3] { "C#", "Asp.net", "Js" };
        }
        public int Experience;
        public string[] Knowledge;

        //polymorphysm
        public override string FullInfo()
        {
            return base.FullInfo()+" "+Experience;
        }
    }
}
