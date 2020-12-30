using System;
using Microsoft.AspNetCore.Mvc;

namespace WorkOverflow.WebApi.Controllers.Health
{
    [ApiController]
    [Route("health")]
    public class HealthCheckController : Controller
    {
        [Route("getHealthStatus")]
        [HttpGet]
        public IActionResult GetHealthStatus()
        {
            return Ok($"Healthy: "+ DateTime.Now);
        }
    }
}
