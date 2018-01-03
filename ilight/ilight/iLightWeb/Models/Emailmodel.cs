using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ilight.Models
{
    public class Emailmodel
    {

        [Required]
        public string To { get; set; }
    }
}
