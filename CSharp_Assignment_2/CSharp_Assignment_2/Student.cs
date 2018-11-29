using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    public class Student :Person
    {
        public double percentage { get; set; }

        #region Constructor
        public Student()
        {

        }

        public Student(string name, double Percentage)
        {
            this.percentage = Percentage;
            this.Name = name;
        }

        #endregion Constructor

        #region Method

        public void display(out string message)
        {
            message = "Student Name :" + this.Name + " has scroed " + this.percentage + "percentage";
        }

        public override bool IsOutStanding()
        {
            string Message;
            display(out Message);
            Console.WriteLine(Message);
            return percentage > 85;
        }


        #endregion Method
    }
}
