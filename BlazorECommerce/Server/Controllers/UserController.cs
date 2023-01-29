using BlazorECommerce.Server.Services;
using BlazorECommerce.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;

namespace BlazorECommerce.Server.Controllers
{
	[Authorize]
	[ApiController]
	[Route("api/[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IUserService userService;

		public UserController(IUserService userService)
		{
			this.userService = userService;
		}

		[HttpGet("me")]
		public async ValueTask<ActionResult<ShopUser>> GetMe()
		{
			var shopUser = await userService.GetAsync(GetUserId());
			return Ok(shopUser);
		}

		private string GetUserId()
			=> User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

		[HttpPut]
		public async ValueTask<ActionResult> Put(ShopUser shopUser)
		{
			await userService.PutAsync(shopUser, GetUserId());
			return NoContent();
		}
	}
}
