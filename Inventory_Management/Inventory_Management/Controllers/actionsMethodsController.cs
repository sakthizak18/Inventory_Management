using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_Management.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class actionsMethodsController : ControllerBase
    {
        private readonly ILogger<actionsMethodsController> _logger;

        public actionsMethodsController(ILogger<actionsMethodsController> logger)
        {
            _logger = logger;
        }

    }
}
