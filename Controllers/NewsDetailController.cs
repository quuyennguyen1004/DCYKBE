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
    public class NewsDetailController : Controller
    {
        private DataContext dataContext;
        IMapper mapper;
        public NewsDetailController(DataContext dataContext, IMapper mapper)
        {
            this.dataContext = dataContext;
            this.mapper = mapper;
        }
        [HttpGet("NewsDetail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            News news = dataContext.Newss.FirstOrDefault(p => p.NewsId == id);

            //ProductModels currentProduct = new ProductModels
            //{
            //    ProductId = products.ProductId,
            //    ProductName = products.ProductName,
            //    ProductImage = products.ProductImage,
            //    Description = products.Description,
            //    ProductPrice = products.ProductPrice
            //};
            //Console.WriteLine(currentProduct);
            return View(news);
        }
    }
}
