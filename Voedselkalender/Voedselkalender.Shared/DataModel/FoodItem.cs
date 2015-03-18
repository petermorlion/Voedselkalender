using System;
using System.Collections.Generic;
using System.Text;

namespace Voedselkalender.DataModel
{
    public class FoodItem
    {
        public string Name { get; set; }

        public List<int> Months { get; set; }

        public string WikipediaKey { get; set; }

        public FoodItemType Type { get; set; }
    }
}
