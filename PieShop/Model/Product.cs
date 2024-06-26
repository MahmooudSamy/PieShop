﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Repositories;
namespace PieShop.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsProductOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Notes { get; set; }
        public string Slug =>StringExtensions.Slugify(Name);

        //Name?.Replace(' ', '-').ToLower()+ '-'+year.tostring
    }
}
