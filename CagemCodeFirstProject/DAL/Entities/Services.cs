﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CagemCodeFirstProject.DAL.Entities
{
    public class Services
    {
        public int ServicesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}