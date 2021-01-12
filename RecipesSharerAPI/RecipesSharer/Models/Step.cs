﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesSharer.Models
{
    public class Step
    {
        public int StepId { get; set; }
        public int StepNumber { get; set; }
        public string Instruction { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe {get;set;}
    }
}
