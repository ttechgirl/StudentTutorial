using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTutorial
{
    public class DelegateEvent
    {
        public delegate void BirthdayHandler(int age, DateTime date);
        //Step2: Define one event to notify the work progress using the custom delegate
        public event BirthdayHandler Birthday;
        //Step2: Define another event to notify when the work is completed using buil-in EventHandler delegate
        public event EventHandler BirthDate;
        public void NotifyPeople(int age, DateTime date)
        {
            for (int i = 0; i < age; i++)
            {
                PreNotification(age, date);
            }
            Notification();
        }

        protected virtual void PreNotification(int age, DateTime date)
        {
            //Raising Events approach 1
            //Birthday?.Invoke(28, date.ToLocalTime());

            //Raising Events approach 2
            //validation
            //if (Birthday == null)
            //{
            //    Console.WriteLine("No event listener");
            //}
            Birthday?.Invoke(5, date.ToLocalTime());
        }

        protected virtual void Notification()
        {
            //Raising Events 

            //approach 1
            BirthDate?.Invoke(this, EventArgs.Empty);

            ////approach 2
            //if (BirthDate is EventHandler evn)
            //{
            //    evn(this, EventArgs.Empty);
            //}

        }

        public event EventHandler<BirthdayProp> BirthdayEvent;

        //Event Handler Method or Event Listener Method
        static void CurrentAge(object sender, BirthdayProp e)
        {
            Console.WriteLine($"Age is {e.Age} as at {e.Date}");
        }
        //Event Handler Method or Event Listener Method
        static void CalculationCompleted(object sender, EventArgs e)
        {
            Console.WriteLine($"Age calculation Completed");
        }
    }

    public class BirthdayProp
    {
        public int Age { get; set; }
        public DateTime Date { get; set; }
    }
}
