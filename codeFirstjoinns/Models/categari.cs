using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirstjoinns.Models
{
    public class categari
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}