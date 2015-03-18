using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Voedselkalender.DataModel
{
    public static class Food
    {
        private static IEnumerable<FoodItem> _food = InitializeFood();

        public static IEnumerable<FoodItem> GetForMonth(int monthNumber)
        {
            return _food.Where(foodItem => foodItem.Months.Contains(monthNumber));
        }

        public static FoodItem GetSingle(string key)
        {
            return _food.Single(foodItem => foodItem.Name == key);
        }

        private static IEnumerable<FoodItem> InitializeFood()
        {
            return new List<FoodItem>
                       {
                           new FoodItem { Name = "Aardappelen", Months = new List<int> { 1, 2, 3, 4, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Aardappel", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Andijvie", Months = new List<int> { 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Andijvie", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Artisjok", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Artisjok", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Asperges", Months = new List<int> { 5, 6 }, WikipediaKey = "Asperge", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Aubergine", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Aubergine_plant", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Bleekselder", Months = new List<int> { 7, 8, 9, 10, 11 }, WikipediaKey = "Bleekselderij", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Bloemkool", Months = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10, 11 }, WikipediaKey = "Bloemkool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Broccoli", Months = new List<int> { 6, 7, 8, 9, 10, 11 }, WikipediaKey = "Broccoli", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Chinese kool", Months = new List<int> { 7, 8, 9, 10, 11 }, WikipediaKey = "Chinese_kool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Courgette", Months = new List<int> { 7, 8, 9, 10, 11 }, WikipediaKey = "Courgette", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Doperwtjes", Months = new List<int> { 5, 6, 7 }, WikipediaKey = "Erwt", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Groene selder", Months = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Selderij", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Knolselder", Months = new List<int> { 1, 2, 3, 8, 9, 10, 11, 12 }, WikipediaKey = "Knolselderij", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Komkommer", Months = new List<int> { 7, 8, 9 }, WikipediaKey = "Komkommer", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Koolrabi", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Koolrabi", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Kropsla", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Sla", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Maïs", Months = new List<int> { 8, 9 }, WikipediaKey = "Mais", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Paddenstoelen", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Paddenstoel_schimmel", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Paprika", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Paprika", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Pastinaak", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Pastinaak", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Pompoen", Months = new List<int> { 1, 2, 3, 8, 9, 10, 11, 12 }, WikipediaKey = "Pompoen", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Prei", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Prei", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Prinsessenbonen", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Sperzieboon", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Raap", Months = new List<int> { 1, 2, 3, 4, 5, 6, 9, 10, 11, 12 }, WikipediaKey = "Knolraap", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Raapstelen", Months = new List<int> { 4, 5, 8, 9, 10 }, WikipediaKey = "Raapstelen", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Radijs", Months = new List<int> { 3, 4, 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Radijs", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Rammenas", Months = new List<int> { 1, 2, 3, 9, 10, 11, 12 }, WikipediaKey = "Rammenas", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Rode biet", Months = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Rode_biet", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Rodekool", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Rodekool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Savooikool", Months = new List<int> { 1, 2, 3, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Savooiekool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Schorseneren", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Grote_schorseneer", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Snijbonen", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Snijboon", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Spinazie", Months = new List<int> { 3, 4, 5, 7, 8, 9, 10 }, WikipediaKey = "Spinazie", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Spitskool", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Spitskool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Spruiten", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Spruitkool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Tomaten", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Tomaat", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Uien", Months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Ui_plant", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Veldsla", Months = new List<int> { 1, 2, 3, 10, 11, 12 }, WikipediaKey = "Veldsla", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Venkel", Months = new List<int> { 6, 7, 9, 10, 11 }, WikipediaKey = "Venkel", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Warmoes", Months = new List<int> { 5, 6, 7, 8, 9, 10 }, WikipediaKey = "Snijbiet", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Witlof", Months = new List<int> { 1, 2, 3, 4, 10, 11, 12 }, WikipediaKey = "Witlof", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Wittekool", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Wittekool", Type = FoodItemType.Vegetable },
                           new FoodItem { Name = "Wortelen", Months = new List<int> { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Wortel_groente", Type = FoodItemType.Vegetable },

                           new FoodItem { Name = "Aardbeien", Months = new List<int> { 5, 6, 7, 8 }, WikipediaKey = "Aardbei", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Abrikozen", Months = new List<int> { 6, 7, 8 }, WikipediaKey = "Abrikoos", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Appelen", Months = new List<int> { 1, 2, 3, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Appel_vrucht", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Bananen", Months = new List<int> { 1, 2, 9, 10, 11, 12 }, WikipediaKey = "Banaan_vrucht", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Bramen", Months = new List<int> { 7, 8, 9, 10 }, WikipediaKey = "Braam_cultuurbraam", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Druiven", Months = new List<int> { 8, 9, 10, 11 }, WikipediaKey = "Druif", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Frambozen", Months = new List<int> { 6, 7, 8, 9, 10 }, WikipediaKey = "Framboos", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Kersen", Months = new List<int> { 6, 7, 8 }, WikipediaKey = "Kers_fruit", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Kiwis", Months = new List<int> { 9, 10, 11, 12 }, WikipediaKey = "Kiwi_fruit", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Mandarijnen", Months = new List<int> { 1, 2, 10, 11, 12 }, WikipediaKey = "Mandarijn_vrucht", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Mango", Months = new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 11, 12 }, WikipediaKey = "Mango_soort", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Meloenen", Months = new List<int> { 8, 9, 10 }, WikipediaKey = "Meloen_vrucht", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Nectarines", Months = new List<int> { 6, 7, 8, 9 }, WikipediaKey = "Nectarine", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Peren", Months = new List<int> { 1, 2, 8, 9, 10, 11, 12 }, WikipediaKey = "Peer_vrucht", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Perziken", Months = new List<int> { 6, 7, 8, 9 }, WikipediaKey = "Perzik", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Pompelmoes", Months = new List<int> { 1, 2, 3, 4, 5, 9, 10, 11, 12 }, WikipediaKey = "Pompelmoes", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Pruimen", Months = new List<int> { 8, 9 }, WikipediaKey = "Pruim", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Rabarber", Months = new List<int> { 3, 4, 5, 6, 7 }, WikipediaKey = "Rabarber", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Rode bessen", Months = new List<int> { 6, 7 }, WikipediaKey = "Rode_bes", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Sinaasappelen", Months = new List<int> { 1, 2, 3, 4, 5, 6, 10, 11, 12 }, WikipediaKey = "Sinaasappel", Type = FoodItemType.Fruit },
                           new FoodItem { Name = "Zwarte bessen", Months = new List<int> { 6, 7, 8 }, WikipediaKey = "Zwarte_bes", Type = FoodItemType.Fruit }
                       };
        }
    }
}
