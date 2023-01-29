using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared.Entities
{
	public sealed class ShopUser
	{
		public string Id { get; set; }

		[Required]
		public string DisplayName { get; set; }

		[Required]
		public string MobilePhone { get; set; }
	}
}
