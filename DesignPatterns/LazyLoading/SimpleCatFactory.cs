using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.LazyLoading
{
    public class SimpleCatFactory
    {
        public AbstractCat GetKitty(string type)
        {
            if (type.Equals("custom"))
            {
                return new CustomLazyCat();
            }
            else if (type.Equals("actual"))
            {
                return new ActualLazyCat();
            }
            else
            {
                return null;
            }
        }
    }
}
