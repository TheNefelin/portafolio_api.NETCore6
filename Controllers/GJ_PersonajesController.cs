using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_personajes")]
    [ApiController]
    public class GJ_PersonajesController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_PersonajesController> _logger;

        public GJ_PersonajesController(
            ConexionBDContext context,
            ILogger<GJ_PersonajesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Personajes_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Personajes_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{IdJuego:int}")]
        public async Task<IEnumerable<dynamic>> GJ_Personajes_ByIdJuego(
            int IdJuego,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Personajes_ByIdJuego(
                IdJuego,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
