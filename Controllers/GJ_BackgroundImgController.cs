using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_background_img")]
    [ApiController]
    public class GJ_BackgroundImgController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_BackgroundImgController> _logger;

        public GJ_BackgroundImgController(
            ConexionBDContext context,
            ILogger<GJ_BackgroundImgController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> GJ_Background_Img_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Background_Img_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{IdJuego:int}")]
        public async Task<IEnumerable<dynamic>> GJ_Background_Img_ByIdJuego(
            int IdJuego,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Background_Img_ByIdJuego(
                IdJuego,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
