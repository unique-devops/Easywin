using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyWin.Models
{   
    public class Acms
    {
        [Key]
        public int Code { get; set; }  // Primary Key
        public string? Name { get; set; }
        public string? Email { get; set; }       
        public string? Contact1Mobile { get; set; }       
        public string? Address { get; set; }
    }
}
