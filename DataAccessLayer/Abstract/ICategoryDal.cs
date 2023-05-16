using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category> // Generic'ten miras al, ilgili sınıfı çağır.
    {
        
    }
}
