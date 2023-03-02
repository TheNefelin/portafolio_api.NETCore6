using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("links")]
    [ApiController]
    public class LinksController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<LinksController> _logger;

        public LinksController(
            ConexionBDContext context,
            ILogger<LinksController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> PA_Links_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Links_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IEnumerable<dynamic>> PA_Links_GetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Links_GetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
