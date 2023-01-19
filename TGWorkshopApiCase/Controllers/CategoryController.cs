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
    public class CategoryController : ApiController
    {
        CategoryManager cm = new CategoryManager();

        public IEnumerable<Category> GetCategoryList()
        {
            var categoryvalues = cm.GetList();

            // Return a 200 OK response with the category
            return categoryvalues;

        }
    }
}
