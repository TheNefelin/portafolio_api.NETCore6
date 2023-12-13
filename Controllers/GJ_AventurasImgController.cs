using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_aventuras_img")]
    [ApiController]
    public class GJ_AventurasImgController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_AventurasImgController> _logger;

        public GJ_AventurasImgController(
            ConexionBDContext context,
            ILogger<GJ_AventurasImgController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Aventuras_Img_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Aventuras_Img_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{IdJuego:int}")]
        public async Task<IEnumerable<dynamic>> GJ_Aventuras_Img_ByIdIdJuego(
            int IdJuego,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Aventuras_Img_ByIdIdJuego(
                IdJuego,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
