using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UpSchoolWebAPI.DAL;
using UpSchoolWebAPI.DAL.Entities;

namespace UpSchoolWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		Context context = new Context();
		[HttpGet]
		public IActionResult CategoryList()
		{
			var values = context.Categories.ToList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CategoryAdd(Category category)
		{
			var value = context.Categories.Add(category);
			context.SaveChanges();
			return Ok();
		}
		[HttpPut]
		public IActionResult CategoryUpdate(Category category)
		{
			var value = context.Categories.Update(category);
			context.SaveChanges();
			return Ok();
		}
		[HttpDelete("{id}")]
		public IActionResult CategoryDelete(int id)
		{
			var category = context.Categories.Find(id);
			context.Categories.Remove(category);
			context.SaveChanges();
			return Ok();
		}
	}
}
