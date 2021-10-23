using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public delegate bool NumCriteria(int x);
        public delegate void Print2(string str1, string str2);
        public delegate void Print3(string str1, string str2, string str3);

        public delegate void GenericPrint<T>(T p);
        public delegate void GenericPrint<T,T2>(T p, T2 p2);
        public delegate void GenericPrint<T,T2,T3>(T p, T2 p2, T3 p3);
        public delegate R FunctionGeneric<in T, out R>(T p);
        public delegate R FunctionGeneric<in T, in T2, out R>(T p1, T2 p2);

        static void Main(string[] args)
        {
            #region
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    numbers.Add(i);
            //}

            //Console.WriteLine(SumNumberByCriteria(numbers, isEven));
            //Console.WriteLine(SumNumberByCriteria(numbers, isOdd));
            //Console.WriteLine(SumNumberByCriteria(numbers, isBiggerThanFive));
            //Console.WriteLine(SumNumberByCriteria(numbers, isPrime));
            #endregion

            //Print prnt = SimplyPrint;
            //prnt += PrintStringLength;
            //prnt += PrintUpperCase;
            //prnt -= PrintUpperCase;

            //prnt("salam");

            //var p1 = new
            //{
            //    Name = "Mamed",
            //    Age = 5
            //};

            //Console.WriteLine(p1.Name);


            //FunctionGeneric<int,bool> numcrit = isOdd;
            //numcrit = numcrit + isEven;
            //numcrit += isPrime;

            //numcrit = delegate (int num)
            //{
            //    return num % 10 == 0;
            //};

            //Console.WriteLine(numcrit(5));


            //Print prnt = SimplyPrint;
            //prnt += PrintStringLength;
            //prnt += PrintUpperCase;
            //prnt -= PrintUpperCase;

            //prnt += z => {
            //        foreach (string item in z.Split("a"))
            //        {
            //            Console.WriteLine(item);
            //        }
            //    };

            //prnt("salam");

            //Print2 prnt2 = (z, y) =>{
            //    Console.WriteLine($"Soz1: {z} Soz2: {y}");
            //};

            //prnt2("salam","salam2");

            //List<int> numbers = new List<int>();
            //for (int i = 2; i < 10; i++)
            //{
            //    numbers.Add(i);
            //}

            //int res = SumNumberByCriteria(numbers, num =>
            //{
            //    return (isOdd(num)&&isPrime(num));
            //});

            //Console.WriteLine(res);

            //GenericPrint<string> gp = SimplyPrint;
            //GenericPrint<int> gpInt = SimplyPrintInt;

            //FunctionGeneric<int, bool> numberCriteria = isOdd;


            //FunctionGeneric<int, string> test = num => {
            //    return num.ToString();
            //};


            //Print2 prnt2 = SimplyPrint;

            //GenericPrint<string, string> gp2 = SimplyPrint;

            //FunctionGeneric<int, int, bool> fg2 = isBiggerThan;

            //Console.WriteLine(fg2(1,2));

            // Action, Function, Predicate

            //Action<int> act = SimplyPrintInt;
            //Action<int,int> act2 = PrintSum;

            //Func<List<int>> func = GetEvenNumsTillHundred;
            //Func<int, bool> func2 = isEven;


            //List<Person> people = new List<Person>();
            //people.Add(new Person("Mamed", "Aliyev", 19, false));
            //people.Add(new Person("Qezenfer", "Azizov", 24, true));
            //people.Add(new Person("Nicat", "Azimzade", 18, true));
            //people.Add(new Person("Isabala", "Tagiyev", 41, true));
            //people.Add(new Person("Mezahir", "Qurbanov", 13, false));

            //Console.WriteLine(people.Exists(p=>p.Age>60));
            //Console.WriteLine(people.Exists(p=>p.Name.ToLower().Contains("isa")));
            //Console.WriteLine(people.Exists(p=>p.IsMarried));

            //Person foundPerson = people.Find(p=>p.Surname.StartsWith("Ali"));
            //List<Person> marriedPeople = people.FindAll(p=>p.IsMarried&&p.Age<25);

            //foreach (Person item in marriedPeople)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //people.ForEach(p=> {
            //    if (p.Age<20)
            //    {
            //        p.IsMarried = false;
            //    }
            //});

            //foreach (Person item in people)
            //{
            //    Console.WriteLine(item.Name + item.IsMarried);
            //}
        }

        static void SimplyPrint(string s)
        {
            Console.WriteLine($"Soz: {s}");
        }
        static void SimplyPrintInt(int num)
        {
            Console.WriteLine($"reqem: {num.ToString()}");
        }
        static void SimplyPrint(string s1, string s2)
        {
            Console.WriteLine($"Soz1: {s1} Soz2: {s1}");
        }

        static public List<int> GetEvenNumsTillHundred()
        {
            List<int> res = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                if (i%2==0)
                {
                    res.Add(i);
                }
            }
            return res;
        }

        static void PrintSum(int a , int b)
        {
            Console.WriteLine(a+b);
        }

        static void PrintUpperCase(string s)
        {
            Console.WriteLine($"Soz boyuk herflerle: {s.ToUpper()}");
        }

        static void PrintStringLength(string s)
        {
            Console.WriteLine($"Sozun uzunlugu: {s.Length}");
        }

        static int SumNumberByCriteria(List<int> nums, FunctionGeneric<int,bool> function)
        {
            int result = 0;
            foreach (int item in nums)
            {
                if (function(item))
                {
                    result += item;
                }
            }
            return result;
        }

        static bool isOdd(int num)
        {
            Console.WriteLine("isOdd isledi");
            return num % 2 != 0;
        }

        static bool isEven(int num)
        {
            Console.WriteLine("isEven isledi");

            return num % 2 == 0;
        }

        static bool isBiggerThanFive(int num)
        {
            return num > 5;
        }

        static bool isPrime(int num)
        {
            Console.WriteLine("isPrime isledi");

            bool result = true;

            for (int i = 2; i < num; i++)
            {
                if (num%i == 0)
                {
                    result = false;
                }
            }

            return result;
        }

        static bool isBiggerThan(int num1, int num2)
        {
            return num1 > num2;
        }

        static void Test(int num)
        {
            Console.WriteLine(num);
        }
    }
}
