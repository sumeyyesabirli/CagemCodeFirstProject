﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CagemCodeFirstProject.DAL.Entities
{
    public class Galery
    {
        public int GaleryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}