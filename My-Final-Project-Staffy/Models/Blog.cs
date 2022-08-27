using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Final_Project_Staffy.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        [StringLength(maximumLength:130,ErrorMessage ="Başlığın uzunluğu yalnız 130 hərf və simvollardan ibarətdir.")]
        public string Title { get; set; }
        [StringLength(maximumLength: 390,ErrorMessage = "Təsvirin uzunluğu yalnız 130 hərf və simvollardan ibarətdir.")]
        public string Subtitle { get; set; }
        public string Date { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        internal bool PhotoIsImage()
        {
            throw new NotImplementedException();
        }
    }
}
