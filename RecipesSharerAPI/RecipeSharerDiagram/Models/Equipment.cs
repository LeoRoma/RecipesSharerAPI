﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesSharer.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
     
    }
}
