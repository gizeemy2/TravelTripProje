using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Classes
{
    public class AdressBlog
    {
        [Key]
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public string AdressOpen{ get; set; }
        public string Mail{ get; set; }
        public int Phone{ get; set; }
        public string Location{ get; set; }
    }
}