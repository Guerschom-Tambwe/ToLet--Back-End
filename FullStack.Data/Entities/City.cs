using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.Data.Entities
{
    public class City
    {
        public int CityId { get; set; } 
        public string CityName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}