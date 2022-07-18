using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestAPIController : ControllerBase
    {
        // , "Red", "Simmy", "Rin", "Tim", "Xin", "Balmy", "No", "Cherry", "Mon"
        private static readonly AnimalInfo[] Names = new[]
        {
           new AnimalInfo { Name= "SuChi", Type = "Dog" }           
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
        public IEnumerable<DogCatId> Get(string[] Animals)
        {
            return Enumerable.Range(1, 5).Select(index => new DogCatId
            {
                
                Animal = Animals[Random.Shared.Next(Animals.Length)],
                Name = Names[Random.Shared.Next(Names.Length)]
            })
            .ToArray();
        }
    }

    public class AnimalInfo
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}