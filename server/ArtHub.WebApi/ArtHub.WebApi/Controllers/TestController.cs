using Microsoft.AspNetCore.Mvc;

namespace ArtHub.WebApi.Controllers;

#if DEBUG
[Controller]
public class TestController : ControllerBase
{
	[HttpGet]
	public IActionResult Index()
	{
		return Ok("index");
	}

	[HttpGet]
	public IActionResult Test1()
	{
		return Ok("test 1");
	}
}
#endif