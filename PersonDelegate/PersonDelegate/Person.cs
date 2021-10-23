using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDelegate
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public Person(string name , string surname, int age, bool isMarried)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMarried = isMarried;
        }
    }
}
