using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FullStack.Data.Entities
{
    public class Advert
    {
        public int AdvertId { get; set; }
        public string Headline { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string AdvertDetails { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; } 
        public int UserId { get; set; }
        public string AdvertStatus { get; set; } = "LIVE";
        public DateTimeOffset PublishedDate { get; set; } = new DateTimeOffset();


    }
}
