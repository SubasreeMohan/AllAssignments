using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_2
{
    public class Person
    {
        public string Name { get; set; }

        #region Constructor
        public Person()
        {

        }

        public Person(string Name)
        {
            this.Name = Name;
        }
        #endregion Constructor

        #region Method
        public virtual bool IsOutStanding()
        {
            return true;
        }

        #endregion Method



    }
}
