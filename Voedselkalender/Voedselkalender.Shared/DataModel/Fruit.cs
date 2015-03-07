using System;
using System.Collections.Generic;
using System.Text;

namespace Voedselkalender.DataModel
{
    public static class Fruit
    {
        private static IList<FoodItem> _data;

        public static IList<FoodItem> All()
        {
            if (_data == null)
            {
                Initialize();
            }

            return _data;
        }

        public static void Initialize()
        {
            _data = new List<FoodItem>
                       {
                           new FoodItem { Name = "Aardbeien", Months = new List<int> { 5, 6, 7, 8 }, WikipediaKey = "Aardbei" },
                           new FoodItem { Name = "Abrikozen", Months = new List<int> { 6, 7, 8 }, WikipediaKey = "Abrikoos"  },
                           new FoodItem { Name = "Appelen", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Appel_vrucht"  },
                           new FoodItem { Name = "Bananen", Months = new List<int> { 1, 2, 9, 10, 11, 12 }, WikipediaKey = "Banaan_vrucht"  },
                           new FoodItem { Name = "Bramen", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Braam_cultuurbraam"  },
                           new FoodItem { Name = "Druiven", Months = new List<int> { 8, 9, 10, 11 }, WikipediaKey = "Druif"  },
                           new FoodItem { Name = "Frambozen", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Framboos"  },
                           new FoodItem { Name = "Kersen", Months = new List<int> { 6, 7, 8 }, WikipediaKey = "Kers_fruit"  },
                           new FoodItem { Name = "Kiwis", Months = new List<int> { 9, 10, 11, 12 }, WikipediaKey = "Kiwi_fruit"  },
                           new FoodItem { Name = "Mandarijnen", Months = new List<int> { 1, 2, 10, 11, 12 }, WikipediaKey = "Mandarijn_vrucht"  },
                           new FoodItem { Name = "Mango", Months = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Mango_soort"  },
                           new FoodItem { Name = "Meloenen", Months = new List<int> { 8, 9, 10 }, WikipediaKey = "Meloen_vrucht"  },
                           new FoodItem { Name = "Nectarines", Months = new List<int> { 6, 7, 8, 9 }, WikipediaKey = "Nectarine"  },
                           new FoodItem { Name = "Peren", Months = new List<int> { 1, 2, 8, 9, 10, 11, 12 }, WikipediaKey = "Peer_vrucht"  },
                           new FoodItem { Name = "Perziken", Months = new List<int> { 6, 7, 8, 9 }, WikipediaKey = "Perzik"  },
                           new FoodItem { Name = "Pompelmoes", Months = new List<int> { 1, 2, 3, 4, 5, 9, 10, 11, 12 }, WikipediaKey = "Pompelmoes"  },
                           new FoodItem { Name = "Pruimen", Months = new List<int> { 8, 9 }, WikipediaKey = "Pruim"  },
                           new FoodItem { Name = "Rabarber", Months = new List<int> { 3, 4, 5, 6, 7 }, WikipediaKey = "Rabarber"  },
                           new FoodItem { Name = "Rode bessen", Months = new List<int> { 6, 7 }, WikipediaKey = "Rode_bes"  },
                           new FoodItem { Name = "Sinaasappelen", Months = new List<int> { 1, 2, 3, 4, 5, 6, 10, 11, 12 }, WikipediaKey = "Sinaasappel"  },
                           new FoodItem { Name = "Zwarte bessen", Months = new List<int> { 6, 7, 8 }, WikipediaKey = "Zwarte_bes"  }
                       };
        }
    }
}
