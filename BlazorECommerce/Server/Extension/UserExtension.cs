using BlazorECommerce.Shared.Entities;
using Microsoft.Graph;

namespace BlazorECommerce.Server.Extentions
{
	public static class UserExtension
	{
		public static ShopUser ToShopUser(this User user)
		{
			return new ShopUser
			{
				Id = user.Id,
				DisplayName = user.DisplayName,
				MobilePhone = user.MobilePhone,
			};
		}
	}
}
