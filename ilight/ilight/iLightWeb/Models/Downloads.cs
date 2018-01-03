using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ilight.Models
{
    public class Downloads
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string fileName { get; set; }
        [Required]
        [StringLength(150)]
        public string Location { get; set; }

    }
}
