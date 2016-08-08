using Microsoft.AspNetCore.Mvc;

namespace Api
{
    [Route("[controller]")]
    public class InfoController
    {
        [HttpGet]
        public string Get()
        {
            return "Api is online";
        }
    }
}