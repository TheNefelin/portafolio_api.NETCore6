using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("link")]
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
        public async Task<IEnumerable<dynamic>> Pa_Links(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.Pa_GetAll_Links(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("links")]
        public async Task<IEnumerable<dynamic>> Links(
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
        [Route("grp")]
        public async Task<IEnumerable<dynamic>> LinksGroup(
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
