using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.Model
{ 
    public class Recipe
    {
        public int Id { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public byte[] RecipeImage { get; set; }
        public int RecipeTypeId { get; set; }
   

       public Recipe() { } 
       public Recipe(string name, int recipeTypeId, string description, byte[]? image, int? id = null)
        {
            this.RecipeName = name;
            this.RecipeTypeId = recipeTypeId;
            this.RecipeDescription = description;
            this.RecipeImage = image;
            if (id != null)          // only when editing, a new recipe gets its id from the db
                this.Id = (int)id;
        }
    }
  }