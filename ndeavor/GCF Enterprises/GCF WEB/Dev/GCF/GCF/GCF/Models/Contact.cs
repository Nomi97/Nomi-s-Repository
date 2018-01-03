using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GCF.Models
{
    public class PostContactModel
    {
        [Key]
        public int PostId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Message { get; set; }

    }

    public class MembersModel
    {   [Key]
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string ImageUrl { get; set; }

    }
} 