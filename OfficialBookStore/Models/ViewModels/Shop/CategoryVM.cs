﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OfficialBookStore.Models.Data;

namespace OfficialBookStore.Models.ViewModels.Shop
{
    public class CategoryVM
    {
        public CategoryVM()
        {
        }

        public CategoryVM(CategoryDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Slug = row.Slug;
            Sorting = row.Sorting;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Sorting { get; set; }
    }
}