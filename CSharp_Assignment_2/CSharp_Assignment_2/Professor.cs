using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    public class Professor :Person
    {
        public int bookPublished { get; set; }

        #region Constructor
        public Professor()
        {

        }

        public Professor(string name,int bookpublished)
        {
            this.bookPublished = bookPublished;
            this.Name = name;
        }

        #endregion Constructor

        #region Method

        public void print(out string message)
        {
            message = "Professor Name :" + this.Name + " has published " + this.bookPublished + "number of books";
        }

        public override bool IsOutStanding()
        {
            string Message;
            print(out Message);
            Console.WriteLine(Message);
            return bookPublished > 4;
        }


        #endregion Method
    }
}
