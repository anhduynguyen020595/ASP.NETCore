using System;
using System.Collections;
using System.Collections.Generic;

namespace CS_Linq
{
    public class Brand
    {
        public string Name { set; get; }
        public int ID { set; get; }

        static List<Brand> _brands;
        public static List<Brand> brands
        {
            get
            {
                if (_brands == null)
                {
                    _brands = new List<Brand>() {
                    new Brand{ID = 1, Name = "Company AAA"},
                    new Brand{ID = 2, Name = "Company BBB"},
                    new Brand{ID = 4, Name = "Company CCC"},
                };
                }
                return _brands;
            }
        }
    }
}