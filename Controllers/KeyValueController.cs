using Microsoft.AspNetCore.Mvc;
using MyApi.Data;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[KeyValue]")]
    public class KeyValueController : Controller
    {
        private readonly KeyValueAPIDbContext dbcontext;

        public KeyValueController(KeyValueAPIDbContext dbContext)
        {
            this.dbcontext = dbContext;
        }

        [HttpGet]
        public IActionResult GetKeyValue()
        {
           return Ok  (dbcontext.keyValues.ToList());
           // return View();
        }
    }
}
