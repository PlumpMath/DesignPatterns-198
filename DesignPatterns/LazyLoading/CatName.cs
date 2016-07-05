using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatterns.LazyLoading
{
    public class CatName
    {
        public string FirstName;
        public string LastName;

        public CatName()
        {
            Debug.WriteLine("Constructing a nice Kitty");

            this.FirstName = "Cornelius";
            this.LastName = "Beanstalk";
        }
    }
}
