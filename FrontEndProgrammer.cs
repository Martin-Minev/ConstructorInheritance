using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    class FrontEndProgrammer : Programmer
    {
        public FrontEndProgrammer(string name, int salary) : base(name, salary, new List<string> {"Java", "React"})
        {
            Console.WriteLine("In FrontEnd");
        }
    }
}
