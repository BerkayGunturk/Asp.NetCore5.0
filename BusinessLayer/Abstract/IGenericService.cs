using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T t); //T'den bir t parametresi al !
        void TDelete(T t);

        void TUpdate(T t);

        List<T> TGetList();
        T TGetById(int id);

    }
}
