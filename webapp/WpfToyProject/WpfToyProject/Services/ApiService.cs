using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WpfToyProject.Models;

namespace WpfToyProject.Services
{
    public class ApiService
    {
        private string conn =
            "Server=localhost;Database=Bookrentalshop;Trusted_Connection=True;";

        public async Task<List<Product>> GetProductsAsync()
        {
            var list = new List<Product>();

            using var con = new SqlConnection(conn);
            await con.OpenAsync();

            var cmd = new SqlCommand("SELECT * FROM Products", con);
            var rd = await cmd.ExecuteReaderAsync();

            while (await rd.ReadAsync())
            {
                list.Add(new Product
                {
                    ProductId = (int)rd["ProductId"],
                    ProductName = rd["ProductName"].ToString(),
                    Category = rd["Category"].ToString(),
                    Price = (int)rd["Price"],
                    Stock = (int)rd["Stock"],
                    CreatedAt = (DateTime)rd["CreatedAt"]
                });
            }

            return list;
        }

        public async Task CreateProductAsync(Product p)
        {
            using var con = new SqlConnection(conn);
            await con.OpenAsync();

            var cmd = new SqlCommand(@"
                INSERT INTO Products
                (ProductName, Category, Price, Stock, CreatedAt)
                VALUES (@n,@c,@p,@s,GETDATE())", con);

            cmd.Parameters.AddWithValue("@n", p.ProductName);
            cmd.Parameters.AddWithValue("@c", p.Category);
            cmd.Parameters.AddWithValue("@p", p.Price);
            cmd.Parameters.AddWithValue("@s", p.Stock);

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task UpdateProductAsync(Product p)
        {
            using var con = new SqlConnection(conn);
            await con.OpenAsync();

            var cmd = new SqlCommand(@"
                UPDATE Products
                SET ProductName=@n, Category=@c, Price=@p, Stock=@s
                WHERE ProductId=@id", con);

            cmd.Parameters.AddWithValue("@n", p.ProductName);
            cmd.Parameters.AddWithValue("@c", p.Category);
            cmd.Parameters.AddWithValue("@p", p.Price);
            cmd.Parameters.AddWithValue("@s", p.Stock);
            cmd.Parameters.AddWithValue("@id", p.ProductId);

            await cmd.ExecuteNonQueryAsync();
        }
    }
}