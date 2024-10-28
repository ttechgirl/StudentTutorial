using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTutorial
{
    public static class Collection
    {
        public static void ArrayLists()
        {

            //Adding elements to ArrayList using Addition() method
            ArrayList arrayList1 = new ArrayList();
           
            arrayList1.Add(101);
            arrayList1.Add("Shazy");
            arrayList1.Add(" ");
            arrayList1.Add(true);
            arrayList1.Add(4.5);
            arrayList1.Add(null);

            //Adding Elements to ArrayList using object initializer syntax
            var arrayList2 = new ArrayList
            {
                200,
                "Adeola",
                true,
                true,
                45.80F,
                'B'

            };
            

            //arrayList1.InsertRange(2, arrayList2);
            //iterating through foreach loop
            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}
            // Console.WriteLine("=======================================");

            ////iterating through for loop
            //for (int i = 0; i < arrayList1.Count; i++)
            //{
            //    Console.WriteLine(arrayList1[i]);
            //}

            // Console.WriteLine("=======================================");
            ////accessing elements using indexer
            //int first = (int)arrayList1[0];
            //Console.WriteLine(first);

            // Console.WriteLine("=======================================");

            ////using var
            //var fourth = arrayList2[3];
            //    Console.WriteLine(fourth);

            // Console.WriteLine("=======================================");

            //adding elements of arrayList1 to arrayList2 
            //arrayList2.AddRange(arrayList1);
            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}

            // Console.WriteLine("=======================================");
            //remove range of elements from arraylist
            //arrayList1.RemoveRange(2, 3);
            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=======================================");
            ////remove element at a specific index from arraylist collection 
            //arrayList2.RemoveAt(1);
            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("=======================================");
            //arrayList2.Remove(3);
            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable


        }



        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public char Gender { get; set; }
            public string JobRole { get; set; }
            public bool IsActive { get; set; }
        }

        public interface ICompanyStaffs
        {
            public IList<Employee> Employees { get; set;}
        }   
    }
}
    