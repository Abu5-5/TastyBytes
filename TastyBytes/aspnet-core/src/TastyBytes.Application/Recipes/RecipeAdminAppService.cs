﻿using AutoMapper.Internal.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TastyBytes.Recipes
{
    public class RecipeAdminAppService : CrudAppService<Recipe, RecipeDto, int, PagedAndSortedResultRequestDto>, IRecipeAppService
    {
        private readonly IRepository<Recipe, int> _recipesRepository;

        public RecipeAdminAppService(
            IRepository<Recipe, int> recipesRepository
            )
        : base(recipesRepository)
        {
            _recipesRepository = recipesRepository;
        }


        public override async Task<RecipeDto> GetAsync(int id)
        {
            var recipe = await _recipesRepository.GetAsync(id);


            // custom logic
            recipe.Name = recipe.Name.Trim();

            var recipeDto = ObjectMapper.Map<Recipe, RecipeDto>(recipe);

            return recipeDto;
        }


        public override async Task<RecipeDto> CreateAsync(RecipeDto input)
        {
            var recipe = ObjectMapper.Map<RecipeDto, Recipe>(input);

            // custom logic
            recipe.Name = recipe.Name.Trim();

            await _recipesRepository.InsertAsync(recipe, autoSave: true);

            var recipeDto = ObjectMapper.Map<Recipe, RecipeDto>(recipe);

            return recipeDto;
        }


        public override async Task<RecipeDto> UpdateAsync(int id, RecipeDto input)
        {
            var recipe = await _recipesRepository.GetAsync(id);

            // Only the available values from the imput DTO will be applied to the recipe entity.
            // IMPORTANT: Any values not present in the DTO will remain unchanged in the recipe.
            ObjectMapper.Map<RecipeDto, Recipe>(input, recipe);

            await _recipesRepository.UpdateAsync(recipe,autoSave: true);

            var recipeDto = ObjectMapper.Map<Recipe, RecipeDto>(recipe);

            return recipeDto;
        }


        public override async Task DeleteAsync(int id)
        {
            var recipe = await _recipesRepository.GetAsync(id);

            // custom logic
            if (recipe.Name.Contains("Galnash", StringComparison.OrdinalIgnoreCase))
            {
                throw new UserFriendlyException("you can not delete Galnashs");
            }

            await _recipesRepository.DeleteAsync(id);
        }


        public override async Task<PagedResultDto<RecipeDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var totalCount = await _recipesRepository.GetCountAsync();


            var recipes = await _recipesRepository.GetPagedListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting ?? nameof(Recipe.Name)
                );

            var recipeDtos = ObjectMapper.Map<List<Recipe>, List<RecipeDto>>(recipes);

            var pagedResultDto = new PagedResultDto<RecipeDto>(totalCount, recipeDtos);

            return pagedResultDto;
        }


        public async Task<List<RecipeDto>> GetRecentRecipesAsync(int count = 3)
        {
            var query = await _recipesRepository.GetQueryableAsync();


            var recentRecipes =  query
                                      .OrderByDescending(recipe => recipe.Id)
                                      .Take(count)
                                      .ToList();

            var recentRecipeDtos = ObjectMapper.Map<List<Recipe>, List<RecipeDto>>(recentRecipes);

            return recentRecipeDtos;
        }
    }
}
