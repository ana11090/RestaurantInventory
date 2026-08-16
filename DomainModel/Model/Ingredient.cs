using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Model
{
    public class Ingredient
    {
        public string IngredientName { get; set; }
        public string IngredientType { get; set; }
        public decimal Weight { get; set; }
        public decimal Kcal { get; set; }
        public decimal Price { get; set; }
    }
}
