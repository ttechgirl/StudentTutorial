using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTutorial
{
    public class OOPs
    {
       //nested classes
        public class PureCsharp
        {
            public void Generator()
            {
                Console.WriteLine("Enter password");
                Console.WriteLine("=================");
                Console.WriteLine("Password must be 6 characters long");
                Console.WriteLine("=================");

                var password = Console.ReadLine();

                if (password != null && password.Length >= 6)
                {
                    var guid = Guid.NewGuid().ToString("N")[2..6];
                    int age = 5;
                    var generatedPassword = password + " " + guid; //string concatenation
                    Console.WriteLine($"Suggested password is {generatedPassword}"); //string interpolation
                    return;
                }
                else
                {
                    Console.WriteLine("=================");
                    Console.WriteLine("Wrong password format");
                    return;
                }
            }
        }

        //Inheritance , polymorphism and overriding
        public class Zoo  //base
        {
            public virtual void Animal()
            {
                Console.WriteLine("This is the base class");
            }
        }


        public class Zoom : Zoo
        {
            public override void Animal()
            {
                Console.WriteLine("This is the derived class");

            }

        }

       // Abstraction
        public interface ISchool
        {
            void Student();
            public string BookShop { get; set; }

        }

        public class School : ISchool
        {
            public string BookShop { get => BookShop; set => throw new NotImplementedException(); } //property

            public void Student()
            {
                var age = 40;
                var name = "Shola";

                Console.WriteLine($"Student name is {name}");

                //data types
                int blue = 100;
                string firstName = "Victoria";
                firstName = "Ajoke"; //reassignment
                char grade = 'A';
                Console.WriteLine($"Hello, {firstName} got {grade} in her english exam!"); //string interpolation
                Console.WriteLine($"{firstName} is got {blue} in her english exam!"); //string interpolation
                return;
            }

            public void Football()
            {
                //data types

                return;
            }

        }
    }
}
