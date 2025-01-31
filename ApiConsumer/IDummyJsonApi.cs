using ApiConsumer.Models;
using Refit;

namespace ApiConsumer
{
    public interface IDummyJsonApi
    {
        [Get("/product")]
        Task<ProductResponse> GetAllProducts();
    }
}
