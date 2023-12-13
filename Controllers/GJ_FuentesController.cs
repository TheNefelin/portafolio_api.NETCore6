using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_fuentes")]
    [ApiController]
    public class GJ_FuentesController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_FuentesController> _logger;

        public GJ_FuentesController(
            ConexionBDContext context,
            ILogger<GJ_FuentesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Fuentes_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Fuentes_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{IdJuego:int}")]
        public async Task<IEnumerable<dynamic>> GJ_Fuentes_ByIdJuego(
            int IdJuego,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Fuentes_ByIdJuego(
                IdJuego,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
