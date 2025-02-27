﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CagemCodeFirstProject.DAL.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string SocialMedaiName { get; set; }
        public string SocialMedaiUrl { get; set; }
        public  int GuideId { get; set; }
        public string Icon { get; set; }
        public virtual Guide Guide { get; set;}
    }
}