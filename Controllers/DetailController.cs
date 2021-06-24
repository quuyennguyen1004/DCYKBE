using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webtt.Data;
using Webtt.Models;

namespace Webtt.Controllers
{
    public class DetailController : Controller
    {
         private DataContext dataContext;
        IMapper mapper;
        public DetailController(DataContext dataContext,IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        [HttpGet("Detail/{name}")]
        public IActionResult Index(int id)
        {
            ViewBag.RelatedProduct = ListRelatedProduct(id);
            var products = dataContext.Products.FirstOrDefault(p => p.ProductId == id);

            //ProductModels currentProduct = new ProductModels
            //{
            //    ProductId = products.ProductId,
            //    ProductName = products.ProductName,
            //    ProductImage = products.ProductImage,
            //    Description = products.Description,
            //    ProductPrice = products.ProductPrice
            //};
            //Console.WriteLine(currentProduct);
            return View(products);
        }
        public List<Product> ListRelatedProduct(int productId)
        {
            var product = dataContext.Products.Find(productId);
            if (product == null) 
            {
                return null;
            }
            return dataContext.Products.Where(x => x.ProductId != productId  && x.CategoryId == product.CategoryId).ToList();
        }
    }
}
