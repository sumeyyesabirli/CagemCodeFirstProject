using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CagemCodeFirstProject.DAL.Entities
{
    public class FooterContact
    {
        [Key]
        public int FooterId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Icon { get; set; }
    }
}