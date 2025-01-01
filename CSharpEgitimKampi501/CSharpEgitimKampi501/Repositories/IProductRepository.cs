﻿using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    internal interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();

        Task CreateProductAsync(CreateProductDto createProductDto);
        Task updateProductAsync(UpdateProductDto updateProductDto);

        Task DeleteProductAysnc(int id);

        Task GetByProductIdAsync(int id);
    }
}
