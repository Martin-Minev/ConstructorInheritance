using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    public class Programmer : Employee
    {
        public Programmer(string name, int salary, List<string> languages) : base (name, salary)
        {
            this.Languages = languages;
            Console.WriteLine("In Programmer");
        }

        public Programmer(string name, List<string> languages) : base(name, 0)
        {
            this.Languages = languages;
            Console.WriteLine("In Programmer without salary");
        }

        public List<string> Languages { get; set; }
    }
}
