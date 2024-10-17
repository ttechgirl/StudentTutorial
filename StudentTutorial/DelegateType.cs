using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // handler method
        public string Countries(int number, Countries countries)
        {

            return "";
        }

    }
}
