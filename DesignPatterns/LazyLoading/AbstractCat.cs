using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DesignPatterns.LazyLoading
{
    public class AbstractCat
    {      
        public CatName Name;
        public void Meow()
        {
            Debug.WriteLine("My name is " + Name.FirstName + " " + Name.LastName);
        }
    }
}
