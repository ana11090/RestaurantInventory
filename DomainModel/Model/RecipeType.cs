using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel.Model
{
    [Table("RecipeTypes")]
    public class RecipeType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
