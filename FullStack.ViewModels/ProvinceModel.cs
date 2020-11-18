using FullStack.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStack.ViewModels
{
    public class ProvinceModel
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }


    }
}
