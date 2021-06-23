using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            Product products = dataContext.Products.FirstOrDefault(p => p.ProductId == id);

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
        //[HttpGet("Detail/{id}/{name}")]
        //public IActionResult Detail(int id)
        //{
        //    Product products = dataContext.Products.FirstOrDefault(p => p.ProductId == id);
        //    return View(products);
        //}
    }
}
