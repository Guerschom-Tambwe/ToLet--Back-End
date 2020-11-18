using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack.ViewModels
{
    public class AdvertModel
    {
        public int AdvertId { get; set; }
        public string Headline { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string AdvertDetails { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public string AdvertStatus { get; set; }
        public DateTimeOffset PublishedDate { get; set; }
    }
}
