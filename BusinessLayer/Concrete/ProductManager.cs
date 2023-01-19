using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductManager
    {
        GenericRepository<Product> repo = new GenericRepository<Product>();

        public List<Product> GetList()
        {
            return repo.List();
        }
    }
}
