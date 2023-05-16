using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)  //!! constraction kullanımı !!
        {
            _productDal = productDal;   
        }

        public void TDelete(Product t)
        {
            _productDal.Delete(t); //Delete kısa ve öz bu kadar
        }

        public Product TGetById(int id) // GET görünce aklına --return-- gelsin !
        {
            return _productDal.GetById(id);
        }

        public List<Product> TGetList() // GET görünce aklına --return-- gelsin !
        {
            return _productDal.GetList();
        }

        public void TInsert(Product t)
        {
            _productDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _productDal.Update(t);
        }
    }
}
