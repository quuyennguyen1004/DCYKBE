using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webtt.Data;
using Webtt.Models;

namespace Webtt.Controllers
{
    public class HomeController : Controller
    {
        DataContext dataContext;
        IMapper mapper;

        public HomeController(DataContext dataContext, IMapper mapper)
        {

            this.dataContext = dataContext;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            List<ProductModels> products = new List<ProductModels>();
            List<Product> productss = dataContext.Products.ToList();
            
            foreach(var item in productss)
            {
                var map = mapper.Map<ProductModels>(item);
                products.Add(map);
            }
            return View(products);
        }
        public IActionResult Search(string search)
        {
            var item = dataContext.Products.Where(p => p.ProductName.ToLower().Contains(search.ToLower())).ToList();
            return View(item);
        }
        public IActionResult ChuyenKhoa()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 1).ToList());
        }
        public IActionResult TapDi()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 2).ToList());
        }
        public IActionResult ThamMy()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 3).ToList());
        }
        public IActionResult TriLieu()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 4).ToList());
        }
        public IActionResult Inox()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 5).ToList());
        }
        public IActionResult DaiNep()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 6).ToList());
        }
        public IActionResult Den()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 7).ToList());
        }
        public IActionResult MayMoc()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 8).ToList());
        }
        public IActionResult MeBe()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 9).ToList());
        }
        public IActionResult TTBYK()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 10).ToList());
        }
        public IActionResult TieuHao()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 11).ToList());
        }
        public IActionResult VoYK()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 12).ToList());
        }
        public IActionResult SPMoi()
        {
            return View(dataContext.Products.Where(p => p.CategoryId == 13).ToList());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
