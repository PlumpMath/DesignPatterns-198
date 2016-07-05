using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
    public class CustomLazyCat : AbstractCat
    {
        public CatName _name;                    

        public new CatName Name
        {
            get
            {
                if(_name == null)
                {
                    _name = new CatName();                    
                }
                return _name;
            }            
        }    
    }
}
