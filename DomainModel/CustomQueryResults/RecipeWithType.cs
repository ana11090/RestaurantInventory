using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel.CustomQueryResults
{
    public class RecipeWithType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int RecipeTypeId { get; set; }
        public byte[] Image { get; set; } 
    }
}
