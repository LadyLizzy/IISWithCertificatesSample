using System.Web.Http;

namespace IISWithCertificatesSample.WebApi.Controllers
{
    public class CatsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("A lot of cats meowing for food");
        }
    }
}
