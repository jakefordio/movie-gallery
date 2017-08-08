using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
    public class Movie
    {
        string Id { get; set; }
        string Title { get; set; }
        string Rated { get; set; }
        string Length { get; set; }
        string PlotHtml { get; set; }
        string[] Actors { get; set; }

        public string displayText
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
                return Title.Replace(" ", "-").ToLower() + "-" + Id;
            }
        }
    }


}