using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestAPIController : ControllerBase
    {
        private static readonly string[] NameOfCat = new[]
        {
            "SuChi", "Red", "Simmy", "Rin", "Tim"
        };
        
        private static readonly string[] NameOfDog = new[]
        {
            "Xin", "Balmy", "No", "Cherry", "Mon"
        };


        private static readonly string[] Animals = new[]
        {
            "Dog", "Cat"
        };



        private readonly ILogger<TestAPIController> _logger;

        public TestAPIController(ILogger<TestAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "DogCatId")]
        public IEnumerable<DogCatId> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new DogCatId
            {
                Animal = Animals[Random.Shared.Next(Animals.Length)],
                Name = Names[Random.Shared.Next(Names.Length)]
            })
            .ToArray();
        }

        
    }
}