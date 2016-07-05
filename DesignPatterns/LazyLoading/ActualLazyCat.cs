using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
    public class ActualLazyCat : AbstractCat
    {
        public Lazy<CatName> _nameInitializer;

        public new CatName Name
        {
            get
            {               
                return _nameInitializer.Value;
            }
        }

        public ActualLazyCat()
        {
            _nameInitializer = new Lazy<CatName>(() => new CatName { FirstName = "Lazy", LastName = "Kitty" });         
        }
    }
}
