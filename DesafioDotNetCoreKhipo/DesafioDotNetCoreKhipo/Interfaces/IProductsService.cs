using DesafioDotNetCoreKhipo.Models;

namespace DesafioDotNetCoreKhipo.Interfaces
{
    public interface IProductsService
    {
        Task<List<Products>> GetProducts(); 
        Task<Products> GetProducts(int id); 
        Task<Products> AddProducts(Products product); 
        Task<Products> UpdateProducts(Products product); 
        Task<(bool, string)> DeleteProducts(Products product); 
    }
}
