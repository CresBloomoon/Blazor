using BlazorECommerce.Client.Util;
using BlazorECommerce.Shared.Entities;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services
{
	public interface IPublicProductService
	{
		ValueTask<List<Product>> GetAllAsync();
	}
	public class PublicProductService : IPublicProductService
	{
		private readonly HttpClient _httpClient;

		public PublicProductService(PublicHttpClient client)
		{
			_httpClient = client.Http;
		}

		public async ValueTask<List<Product>> GetAllAsync()
		{
			var response = await _httpClient.GetAsync("api/product");
			return await response.Content.ReadFromJsonAsync<List<Product>>();
		}
	}
}
