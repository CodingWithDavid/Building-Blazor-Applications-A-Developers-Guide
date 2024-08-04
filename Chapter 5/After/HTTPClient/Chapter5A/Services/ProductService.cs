using Chapter5.Models;

namespace Chapter5.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7106/api/products");
            response.EnsureSuccessStatusCode();

            var data = await response.Content.ReadFromJsonAsync<List<Product>>();
            if(data != null)
            {
                return data;
            }
            return new List<Product>();
        }
    }

}
