using System;
using System.Collections.Generic;

namespace PersonDelegate
{
    class Program
    {

        public delegate bool PersonCriteria(Person p);
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Mamed", "Aliyev", 19, false));
            people.Add(new Person("Isabala", "Tagiyev", 41, true));
            people.Add(new Person("Mezahir", "Qurbanov", 13, false));

            Console.WriteLine(ConcatPersonNamesByCriteria(people, isMarried));
            Console.WriteLine(ConcatPersonNamesByCriteria(people, isAdult));
        }


        static string ConcatPersonNamesByCriteria(List<Person> people, PersonCriteria crit)
        {
            string result = "";
            foreach (Person item in people)
            {
                if (crit(item))
                {
                    result += $"{item.Name} {item.Surname}, ";
                }
            }
            return result;
        }

        static bool isMarried(Person person)
        {
            return person.IsMarried;
        }

        static bool isAdult(Person person)
        {
            return person.Age>18;
        }
    }
}
