using InMemory.Entities;
using InMemory.Repository;
using Microsoft.AspNetCore.Mvc;

namespace InMemory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        readonly IAuthorRepository _authorRepository;
        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpGet]
        public ActionResult<List<Author>> Get()
        {
            return Ok(_authorRepository.GetAuthors());
        }
    }
}
