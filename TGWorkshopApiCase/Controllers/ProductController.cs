using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace TGWorkshopApiCase.Controllers
{
    public class ProductController : ApiController
    {
        ProductManager cm = new ProductManager();

        public IEnumerable<Product> GetProductList()
        {
            var productvalues = cm.GetList();

            // Return a 200 OK response with the category
            return productvalues;

        }
    }
}
