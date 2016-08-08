using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Api
{
    [Route("[controller]")]
    public class InfoController
    {
        private AppSettings AppSettings { get; set; }

        public InfoController(IOptions<AppSettings> settings)
        {
            AppSettings = settings.Value;
        }

        [HttpGet]
        public string Get()
        {
            return $"[{AppSettings.Title}] is online";
        }
    }
}