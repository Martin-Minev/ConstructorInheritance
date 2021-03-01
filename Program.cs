using System;
using System.Collections.Generic;

namespace ConstructorInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            FrontEndProgrammer frontEnd = new FrontEndProgrammer("Dimitrichko", 3700);
            Console.WriteLine(frontEnd);
            Programmer programmer = new Programmer("Gogi", new List<string>{"JavaScript", "React"});
            Programmer programmerTwo = new Programmer("Manitu", 5500, new List<string> {"C", "C++", "C Sharp"});
            Console.WriteLine(programmer);
            Console.WriteLine(programmerTwo);
        }
    }
}
