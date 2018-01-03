using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilight.Models
{
    public class Users
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }
        [Required]
        [Index("IX_Email", 1, IsUnique = true)]
        [StringLength(50)]

        public string Email { get; set; }
        [Required]
        [StringLength(150)]
        public string Password { get; set; }
        [Required]
        [StringLength(150)]
        public string Salt { get; set; }
        [Required]
        [StringLength(30)]
        public string Company { get; set; }
        [Required]
        public int Active { get; set; }
        [Required]
        [StringLength(50)]
        public string verifyCode { get; set; }

        [StringLength(50)]
        public string resetCode { get; set; }
    }


}
