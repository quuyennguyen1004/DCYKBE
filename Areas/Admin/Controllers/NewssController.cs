using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Webtt.Data;
using Webtt.Models;

namespace Webtt.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class NewssController : Controller
    {
        private readonly DataContext dataContext;
        private readonly IMapper mapper;
        private readonly IWebHostEnvironment webHostEnvironment;

        public NewssController(DataContext context, IWebHostEnvironment hostEnvironment)
        {
            dataContext = context;
            webHostEnvironment = hostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var news = await dataContext.Newss.ToListAsync();
            return View(news);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(NewsModels model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                News news = new News
                {
                    NewsTitle = model.NewsTitle,
                    NewsContent = model.NewsContent,
                    NewsImage = uniqueFileName,
                };
                dataContext.Add(news);
                await dataContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string UploadedFile(NewsModels model)
        {
            string uniqueFileName = null;

            if (model.NewsImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.NewsImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.NewsImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        //public NewssController(DataContext dataContext, IMapper mapper)
        //{
        //    this.dataContext = dataContext;
        //    this.mapper = mapper;
        //}
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    List<NewsModels> news = new List<NewsModels>();
        //    List<News> newss = dataContext.Newss.ToList();
        //    foreach (var item in newss)
        //    {
        //        var map = mapper.Map<NewsModels>(item);
        //        news.Add(map);
        //    }
        //    return View(newss);
        //}
        //[HttpGet]
        //public IActionResult Add()
        //{
        //    NewsModels news = new NewsModels();
        //    //ViewData["CategoryId"] = new SelectList(dataContext.Categories, "CategoryId", "CategoryId");
        //    //ViewData["CategoryName"] = new SelectList(dataContext.Categories, "CategoryName", "CategoryName");
        //    return View(news);
        //}
        //[HttpPost]
        //public IActionResult Add(NewsModels newsModels, IFormFile photo)
        //{
        //    var valid = dataContext.Newss;
        //    if (ModelState.IsValid)
        //    {
        //        NewsModels newNews = new NewsModels();
        //        if (photo == null || photo.Length == 0)
        //        {
        //            newNews.NewsImage = "abc.png";
        //        }
        //        else
        //        {
        //            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", photo.FileName);
        //            var stream = new FileStream(path, FileMode.Create);
        //            photo.CopyToAsync(stream);
        //            newNews.NewsImage = photo.FileName;
        //        }
        //        newNews.NewsTitle = newsModels.NewsTitle;
        //        newNews.NewsContent = newsModels.NewsContent;
        //        //newNews.CreateDate = DateTime.Now;
        //        //productData.ProductList.Add(newProduct);
        //        News p = new News()
        //        {
        //            NewsTitle = newNews.NewsTitle,
        //            NewsContent = newNews.NewsContent,
        //            NewsImage = newNews.NewsImage,

        //        };
        //        //ViewData["CategoryId"] = new SelectList(dataContext.Categories, "CategoryId", "CategoryId", p.CategoryId);
        //        dataContext.Newss.Add(p);
        //        dataContext.SaveChanges();
        //        return RedirectToAction("Index", "Newss");
        //    }
        //    else
        //    {
        //        return View(newsModels);
        //    }
        //}
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //ProductModels oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            News news = dataContext.Newss.FirstOrDefault(p => p.NewsId == id);
            NewsModels oldNews = new NewsModels()
            {
                NewsId = news.NewsId,
                NewsTitle = news.NewsTitle,
                NewsContent = news.NewsContent,
                //NewsImage = news.NewsImage
            };
            return View(oldNews);
        }
        [HttpPost]
        public IActionResult Edit(int id, NewsModels newsModels)
        {
            if (ModelState.IsValid)
            {
                News p1 = dataContext.Newss.FirstOrDefault(p => p.NewsId == id);
                p1.NewsTitle = newsModels.NewsTitle;
                p1.NewsContent = newsModels.NewsContent;
                //p1.NewsImage = newsModels.NewsImage;
                dataContext.SaveChanges();
                ViewBag.Status = 1;
                return RedirectToAction("Index", "Newss");
            }
            else
            {
                return View(newsModels);
            }
        }
        public IActionResult Delete(int id)
        {
            News news = dataContext.Newss.FirstOrDefault(p => p.NewsId == id);
            NewsModels oldNews = new NewsModels()
            {
                NewsId = news.NewsId,
                NewsTitle = news.NewsTitle,
                NewsContent = news.NewsContent,
                //NewsImage = news.NewsImage
            };
            return View(oldNews);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            //productData.ProductList.RemoveAll(p => p.ProductId == id);
            News news = dataContext.Newss.FirstOrDefault(p => p.NewsId == id);
            dataContext.Newss.Remove(news);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "Newss");
        }
    }
}
