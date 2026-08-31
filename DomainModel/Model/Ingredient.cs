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
        public decimal KcalPer100g { get; set; }
        public decimal Price { get; set; }

        public Ingredient() { }

        public Ingredient(string name, string type, decimal weight, decimal kcal, decimal price)
        {
            this.IngredientName = name;
            this.IngredientType = type;
            this.Weight = weight;
            this.KcalPer100g = kcal;
            this.Price = price;
        }

     
    }
}
