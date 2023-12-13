using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_guias")]
    [ApiController]
    public class GJ_GuiasController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_GuiasController> _logger;

        public GJ_GuiasController(
            ConexionBDContext context,
            ILogger<GJ_GuiasController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Guias_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Guias_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{IdJuego:int}")]
        public async Task<IEnumerable<dynamic>> GJ_Guias_ByIdJuego(
            int IdJuego,
            [Required] string User,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Guias_ByIdJuego(
                IdJuego,
                User,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
