using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CagemCodeFirstProject.DAL.Entities
{
    public class Guide
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideTitle { get; set;}
        public string GuideImageUrl { get; set;}
    }
    
}