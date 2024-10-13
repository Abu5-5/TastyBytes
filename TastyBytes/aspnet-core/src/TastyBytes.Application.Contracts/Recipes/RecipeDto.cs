﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace TastyBytes.Recipes
{
    public class RecipeDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}