using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rated { get; set; }
        public string Length { get; set; }
        public string PlotHtml { get; set; }
        public string[] Actors { get; set; }

        public string DisplayText
        {
            get
            {
                return Id + " - " + Title;
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return Title.Replace(" ", "-").ToLower() + "-" + Id + ".jpg";
            }
        }
    }
}