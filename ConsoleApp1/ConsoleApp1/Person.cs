using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        private List<int> _marks;

        private int maxMarkCount;

        public bool AddMark(int mark)
        {
            if (_marks.Count== maxMarkCount)
            {
                return false;
            }
            else
            {
                _marks.Add(mark);
                return true;
            }
        }

        public Person(string name, string surname, int age, bool isMarried)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMarried = isMarried;
        }
    }
}
