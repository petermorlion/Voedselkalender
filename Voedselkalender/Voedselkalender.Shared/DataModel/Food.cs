﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voedselkalender.DataModel
{
    public static class Food
    {
        private static IEnumerable<FoodItem> _food = InitializeFood();

        public static IEnumerable<FoodItem> GetAll()
        {
            return _food;
        }

        public static IEnumerable<FoodItem> GetForMonth(int monthNumber)
        {
            return _food.Where(foodItem => foodItem.Months.Contains(monthNumber));
        }

        private static IEnumerable<FoodItem> InitializeFood()
        {
            return new List<FoodItem>
                       {
                           new FoodItem { Name = "Aardappelen", Months = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Aardappel" },
                           new FoodItem { Name = "Andijvie", Months = new List<int> { 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Andijvie" },
                           new FoodItem { Name = "Artisjok", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Artisjok" },
                           new FoodItem { Name = "Asperges", Months = new List<int> { 5, 6 }, WikipediaKey = "Asperge" },
                           new FoodItem { Name = "Aubergine", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Aubergine_plant" },
                           new FoodItem { Name = "Bleekselder", Months = new List<int> { 7, 8, 9, 10, 11 }, WikipediaKey = "Bleekselderij" },
                           new FoodItem { Name = "Bloemkool", Months = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11 }, WikipediaKey = "Bloemkool" },
                           new FoodItem { Name = "Broccoli", Months = new List<int> { 6, 7, 8, 9, 10, 11 }, WikipediaKey = "Broccoli" },
                           new FoodItem { Name = "Chinese kool", Months = new List<int> { 7, 8, 9, 10, 11 }, WikipediaKey = "Chinese_kool" },
                           new FoodItem { Name = "Courgette", Months = new List<int> { 7, 8, 9, 10, 11 }, WikipediaKey = "Courgette" },
                           new FoodItem { Name = "Doperwtjes", Months = new List<int> { 5, 6, 7 }, WikipediaKey = "Erwt" },
                           new FoodItem { Name = "Groene selder", Months = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Selderij" },
                           new FoodItem { Name = "Knolselder", Months = new List<int> { 1, 2, 3, 8, 9, 10, 11, 12 }, WikipediaKey = "Knolselderij" },
                           new FoodItem { Name = "Komkommer", Months = new List<int> { 7, 8, 9 }, WikipediaKey = "Komkommer" },
                           new FoodItem { Name = "Koolrabi", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Koolrabi" },
                           new FoodItem { Name = "Kropsla", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Sla" },
                           new FoodItem { Name = "Maïs", Months = new List<int> { 8, 9 }, WikipediaKey = "Mais" },
                           new FoodItem { Name = "Paddenstoelen", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Paddenstoel_schimmel" },
                           new FoodItem { Name = "Paprika", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Paprika" },
                           new FoodItem { Name = "Pastinaak", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Pastinaak" },
                           new FoodItem { Name = "Pompoen", Months = new List<int> { 1, 2, 3, 8, 9, 10, 11, 12 }, WikipediaKey = "Pompoen" },
                           new FoodItem { Name = "Prei", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Prei" },
                           new FoodItem { Name = "Prinsessenbonen", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Sperzieboon" },
                           new FoodItem { Name = "Raap", Months = new List<int> { 1, 2, 3, 4, 5, 6, 9, 10, 11, 12 }, WikipediaKey = "Knolraap" },
                           new FoodItem { Name = "Raapstelen", Months = new List<int> { 4, 5, 8, 9, 10 }, WikipediaKey = "Raapstelen" },
                           new FoodItem { Name = "Radijs", Months = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Radijs" },
                           new FoodItem { Name = "Rammenas", Months = new List<int> { 1, 2, 3, 9, 10, 11, 12 }, WikipediaKey = "Rammenas" },
                           new FoodItem { Name = "Rode biet", Months = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Rode_biet" },
                           new FoodItem { Name = "Rodekool", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Rodekool" },
                           new FoodItem { Name = "Savooikool", Months = new List<int> { 1, 2, 3, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Savooiekool" },
                           new FoodItem { Name = "Schorseneren", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Grote_schorseneer" },
                           new FoodItem { Name = "Snijbonen", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Snijboon" },
                           new FoodItem { Name = "Spinazie", Months = new List<int> { 3, 4, 5, 7, 8, 9, 10 }, WikipediaKey = "Spinazie" },
                           new FoodItem { Name = "Spitskool", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Spitskool" },
                           new FoodItem { Name = "Spruiten", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Spruitkool" },
                           new FoodItem { Name = "Tomaten", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Tomaat" },
                           new FoodItem { Name = "Uien", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Ui_plant" },
                           new FoodItem { Name = "Veldsla", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Veldsla" },
                           new FoodItem { Name = "Venkel", Months = new List<int> { 6, 7, 9, 10, 11 }, WikipediaKey = "Venkel" },
                           new FoodItem { Name = "Warmoes", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Snijbiet" },
                           new FoodItem { Name = "Witlof", Months = new List<int> { 1, 2, 3, 4, 10, 11, 12 }, WikipediaKey = "Witlof" },
                           new FoodItem { Name = "Wittekool", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Wittekool" },
                           new FoodItem { Name = "Wortelen", Months = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Wortel_groente" },

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
