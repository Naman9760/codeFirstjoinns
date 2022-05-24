using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace codeFirstjoinns.Models.Viewmodel
{
    public class ProductViewmodel
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string Decs { get; set; }
        public int Quntety { get; set; }
        public int categari { get; set; }

    }
}