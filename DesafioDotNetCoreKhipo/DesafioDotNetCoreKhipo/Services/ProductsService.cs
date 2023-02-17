using DesafioDotNetCoreKhipo.Data;
using DesafioDotNetCoreKhipo.Interfaces;
using DesafioDotNetCoreKhipo.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioDotNetCoreKhipo.Services
{
    public class ProductsService : IProductsService
    {

        public ProductsService(AppDbContext conn)
        {
            this.conn = conn;
        }
        private readonly AppDbContext conn;

        public async Task<List<Products>> GetProducts()
        {
            try
            {
                return await conn.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Products> GetProducts(int id)
        {
            try
            {
                return await conn.Products.FindAsync(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public async Task<Products> AddProducts(Products products)
        {
            try
            {
                await conn.Products.AddAsync(products);
                await conn.SaveChangesAsync();
                return await conn.Products.FindAsync(products.ID);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Products> UpdateProducts(Products products)
        {
            try
            {
                conn.Entry(products).State = EntityState.Modified;
                await conn.SaveChangesAsync();

                return products;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<(bool, string)> DeleteProducts(Products products)
        {
            try
            {
                var product = await conn.Products.FindAsync(products.ID);

                if (product == null)
                {
                    return (false, "Product could not be found");
                }

                conn.Products.Remove(products);
                await conn.SaveChangesAsync();

                return (true, "Product got deleted.");
            }
            catch (Exception ex)
            {
                return (false, $"An error occured. Error Message: {ex.Message}");
            }
        }

    }
}
