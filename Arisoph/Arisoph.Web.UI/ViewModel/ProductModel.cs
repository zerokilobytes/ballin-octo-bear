using Arisoph.DAL.DomainObject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Arisoph.Web.UI.ViewModel
{
    public class ProductModel
    {
        int PageNumber { get; set; }
        public List<Product> Products { get; set; }
    }
}