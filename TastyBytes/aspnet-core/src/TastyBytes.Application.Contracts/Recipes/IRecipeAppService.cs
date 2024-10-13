﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TastyBytes.Recipes
{
    public interface IRecipeAppService : ICrudAppService<
            RecipeDto,
            int,
            PagedAndSortedResultRequestDto>
    {

        // Create R(single + List) Update, Delete =>
        // C      R                U       D
    }
}
