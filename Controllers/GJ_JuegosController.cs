using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_juegos")]
    [ApiController]
    public class GJ_JuegosController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_JuegosController> _logger;

        public GJ_JuegosController(
            ConexionBDContext context,
            ILogger<GJ_JuegosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Juegos_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Juegos_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{Id:int}")]
        public async Task<dynamic> GJ_Juegos_ById(
            int Id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Juegos_ById(
                Id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
