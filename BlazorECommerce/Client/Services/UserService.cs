using BlazorECommerce.Shared.Entities;
using System.Net.Http.Json;

namespace BlazorECommerce.Client.Services
{
	public interface IUserService
	{
		ValueTask<ShopUser> GetMeAsync();
	}
	public class UserService : IUserService
	{
		private readonly HttpClient httpClient;

		public UserService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}

		public async ValueTask<ShopUser> GetMeAsync()
		{
			var response = await httpClient.GetAsync("api/user/me");
			return await response.Content.ReadFromJsonAsync<ShopUser>();
		}

		public async ValueTask PutAsync(ShopUser user)
		{
			await httpClient.PutAsJsonAsync($"api/user", user);
		}
	}
}
