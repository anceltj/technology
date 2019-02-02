using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Webnewdb.Models
{
    public class Userdemo
    {
        [Required]
        
        public int UserdemoId{ get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string username{ get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password{ get; set; }
    }
}