using CoffeeHouse.Data;
using CoffeeHouse.Data.Models;
using CoffeeHouse.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeHouse.Repository.Implements
{
    public class CategoryRepository: ICategoryRepository
    {
        private readonly CoffeeDbContext _coffeeDbContext;

        public CategoryRepository(CoffeeDbContext coffeeDbContext)
        {
            _coffeeDbContext = coffeeDbContext;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _coffeeDbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            return await _coffeeDbContext.Categories.FirstAsync(c => c.Id == categoryId);
        }
    }
}
