using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("links-group")]
    [ApiController]
    public class LinksGroupController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<LinksGroupController> _logger;

        public LinksGroupController(
            ConexionBDContext context,
            ILogger<LinksGroupController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> PA_Links_Group_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Links_Group_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
