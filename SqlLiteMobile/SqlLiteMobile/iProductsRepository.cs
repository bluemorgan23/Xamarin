﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqlLiteMobile
{
    public interface iProductsRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int id);

        Task<bool> AddProductAsync(Product product);

        Task<bool> UpdateProductAsync(Product product);

        Task<bool> RemoveProductAsync(int id);

        Task<IEnumerable<Product>> QueryProductsAsync(Func<Product, bool> predicate);
    }
}
