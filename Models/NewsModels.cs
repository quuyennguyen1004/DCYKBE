using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webtt.Models
{
    public class NewsModels
    {
        public int NewsId { get; set; }
        [DisplayName("News Title")]
        [Required(ErrorMessage = "Not null")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string NewsTitle { get; set; }
        
        [DisplayName("News Content")]
        [Required(ErrorMessage = "Not null")]
        public string NewsContent { get; set; }
        [DisplayName("Image")]
        [Required(ErrorMessage = "Please choose profile image")]
        public IFormFile NewsImage { get; set; }

   

        private static int nextId = 1;
        public NewsModels()
        {
            NewsId = nextId;
            nextId++;
        }
        public override int GetHashCode()
        {
            return NewsId;
        }
    }
}
