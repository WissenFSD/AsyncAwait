using AsyncAwait.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsyncAwait.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class HomeController : ControllerBase
	{
		private PersonRepository _repository;

		public HomeController(PersonRepository repository)
		{
			_repository = repository;
		}
		[HttpGet]
		[Route("GetSenkronPerson")]
		public IActionResult GetPerson()
		{
			var persons = _repository.GetPerson();
			return Ok(persons);
		}
		[HttpGet]
		[Route("GetAsenkronPerson")]
		public async Task<IActionResult> GetPersonAsync()
		{

			var peoples = await _repository.GetAsyncPerson();
			return Ok(peoples);
		}
	}
}
