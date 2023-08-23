using LocalizationAPI.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace LocalizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly IStringLocalizer<Resource> _stringLocalizer;
        public HelloController(IStringLocalizer<Resource> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        [HttpGet]
        public string Get()
        {
            var value = _stringLocalizer["Hello"];
            return value;
        }
    }
}
