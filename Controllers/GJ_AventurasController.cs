using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_aventuras")]
    [ApiController]
    public class GJ_AventurasController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_AventurasController> _logger;

        public GJ_AventurasController(
            ConexionBDContext context,
            ILogger<GJ_AventurasController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Aventuras_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Aventuras_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{IdJuego:int}")]
        public async Task<IEnumerable<dynamic>> GJ_Aventuras_ByIdJuego(
            int IdJuego,
            [Required] string User,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Aventuras_ByIdJuego(
                IdJuego,
                User,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
