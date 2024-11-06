using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentTutorial.Collection;
using static StudentTutorial.DelegateType;

namespace StudentTutorial
{
    public class DelegateType
    {
        //declaration of delegate
        public delegate void CalculatorDelegate(int x, int y);
        public delegate string Country(int x, int y);

        // handler method
        public static void Calculator(int age, int students)
        {
            Console.WriteLine($"{students} students are within the age range of {age}");
        }

        //declare delegate
        public delegate void CountryDelegate(CountryEnum name);

        //handler method
        public void Countries(CountryEnum name)
        {
            Console.WriteLine($"{name}");
        }

        public void Continent(CountryDelegate name)
        {
            Console.Write($"Continent name:");
            name(CountryEnum.NIGERIA);
        }
    }

    public delegate void MathDelegate(double x, double y);
    public class Calculation
    {
        public void Multiply(double x, double y)
        {
            Console.WriteLine($"Multiplication is: {x * y}");
        }
        public void Addition(double x, double y)
        {
            Console.WriteLine($"Addition is: {x + y}");
        }

        public static void MainMethod()
        {
            //single cast method
            var delegateType = new DelegateType();
            var countryDelegate = new CountryDelegate(delegateType.Countries);
            //countryDelegate.Invoke(CountryEnum.NIGERIA);
            delegateType.Continent(countryDelegate);


            //multicast method
            Calculation cal = new Calculation();
            MathDelegate mathDelegate = new MathDelegate(cal.Multiply);
            //  MathDelegate mathDelegate = cal.Multiply;

            //Adding a method from delegate object
            mathDelegate += cal.Addition;
            mathDelegate(10, 15.00);

            //Removing a method from delegate object
            mathDelegate -= cal.Addition;
            mathDelegate(20.00, 5.00);

            
            //Invoking Multicast Delegate

            Console.ReadKey();

        }
    }


    public class GenericDelegate
    {
        public static void Market()
        {

            //using func generic to declare delegate
            Console.WriteLine("Func: =============");

            Func<int, int, double> Number1Delegate = new Func<int, int, double>(AddNumber1);
          
            //this method or
            //vegDelegate(1, 2);
            //vegDelegate.Invoke(2, 3);
            //this
            double result1 = Number1Delegate(1, 2);
            Console.WriteLine(result1);

            Console.WriteLine("Action:=============");
            Action<int, double> Number2Delegate = new Action<int, double>(AddNumber2);
             Number2Delegate(2,0.6);

            Console.WriteLine("Predicate:=============");
            Predicate<string> CheckNumberDelegate = new Predicate<string>(CheckNumber);
            bool result2 = CheckNumberDelegate.Invoke("English");
            Console.WriteLine(result2);

        }

        public static double AddNumber1(int a1, int a2)
        {
            return a1 + a2;
        }
        public static void AddNumber2(int no1, double no3)
        {
            Console.WriteLine(no1 + no3);
            return;
        }
        public static bool CheckNumber(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

        public delegate void LamdaDelegate(string name);
        public delegate void AnonymousDelegate1(string name);
        public delegate int AnonymousDelegate2(int age);

        //using anonymous method
        public static void AnonymousMethod()
        {
            AnonymousDelegate1 anonymousDelegate = delegate (string name)
            {
              Console.WriteLine($"{name}");
            };
            anonymousDelegate.Invoke("Victorrrrrrr");

            AnonymousDelegate2 anonymousDelegate2 = delegate (int age)
            {
                Console.WriteLine($"{age}");
                return age;
            };
            anonymousDelegate2.Invoke(5);

        }

        //Generic delegate with lamda expression =>

        public static void LamdaExp()
        {
            //way 1 
            Func<int, int, double> Number1Delegate = (x, y) =>
            {
                return x + y;
            };
            Number1Delegate(4, 9);

            //way 2
            LamdaDelegate lamdaDelegate = (name) =>
            {
                Console.WriteLine($"{name}");
            };
            lamdaDelegate.Invoke("Sheyi");

            //
            List<int> numbers = new List<int>() {6000,5,8,9,04,8,6000};
             
            if(numbers.Count > 0)
            {
                foreach(var items  in numbers)
                {
                    Console.WriteLine($"Lists of numbers are {items}");
                }
            }
            else
            {
                Console.WriteLine($"No elements");
            }

            List<string> letters = new List<string>() { };
            if (letters.Count > 0)
            {
                foreach (var items in letters)
                {
                    Console.WriteLine($"Lists of numbers are {items}");
                }
            }
            else
            {
                Console.WriteLine($"No elements");
            }

            
            //linq 
            var num = numbers.Where(n => n.Equals(8)).FirstOrDefault();
            var firstNumb = numbers.Select(u => u).FirstOrDefault();
            var lastNumb = numbers.Select(y => y).LastOrDefault();
            var lett = letters.Select(y => y).LastOrDefault();
            Console.WriteLine($"First or default is :{num}");
            Console.WriteLine($"First or default number selected :{firstNumb}");
            Console.WriteLine($"Last or default number selected :{lastNumb}");
            Console.WriteLine($"Last letter selected :{lett}");

            var numList = numbers.Where(x => x.Equals(8)).ToList();
            foreach (var item in numList)
            {
                Console.WriteLine($"List is :{item}");
            }
        }

        public static void DataSeeding()
        {
            //seeding data 
            List<Employee> employees = new List<Employee>()
            {
               new Employee() {
                   Id = 1 ,
                   FirstName = "Shazy",
                   LastName = "Dev",
                   Gender = 'F',
                   JobRole = "Software Engineer",
                   IsActive = true,
               },
               new Employee() {
                   Id = 2,
                   FirstName = "Victoria",
                   LastName = "Adedoyin",
                   Gender = 'F',
                   JobRole = "Engineer Intern",
                   IsActive = true,
               },
               new Employee() {
                   Id = 3,
                   FirstName = "Adeola",
                   LastName = "Mustapha",
                   Gender = 'F',
                   JobRole = "Customer Service",
                   IsActive = true,
               },
                new Employee() {
                   Id = 4,
                   FirstName = "Sola",
                   LastName = "Jakande",
                   Gender = 'M',
                   JobRole = "HR",
                   IsActive = false,
               },
            };

            //filtering using anonymous type 
            var result = employees.Select(e => new
            {
                e.Id,
                e.FirstName,
                e.LastName,
                e.Gender,
                e.JobRole,
                e.IsActive
            }).ToList();
            foreach (var emp in result)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("GetResult:=============");
            var getResult = result.Where(x => x.Gender == 'F').FirstOrDefault();
            Console.WriteLine(getResult);

            Console.WriteLine("GetResults :=============");

            var getResults = result.Where(x=> !x.IsActive).ToList();
            foreach (var emp in getResults)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
