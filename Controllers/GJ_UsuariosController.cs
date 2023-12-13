using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;
using portafolio_api.NETCore6.Models;

namespace portafolio_api.NETCore6.Controllers
{
    [Route("gj_usuarios")]
    [ApiController]
    public class GJ_UsuariosController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<GJ_UsuariosController> _logger;

        public GJ_UsuariosController(
            ConexionBDContext context,
            ILogger<GJ_UsuariosController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [ApiKeyAuth]
        [HttpPost]
        [Route("")]
        public async Task<dynamic> GJ_Usuario_Post(
            GJ_Usuario tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Usuario_Post(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [ApiKeyAuth]
        [HttpPut]
        [Route("estado_guia")]
        public async Task<dynamic> GJ_Estado_Guia_Put(
            GJ_UsuarioGuia tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Estado_Guia_Put(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [ApiKeyAuth]
        [HttpPut]
        [Route("estado_aventura")]
        public async Task<dynamic> GJ_Estado_Aventura_Put(
            GJ_UsuarioAventura tb,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.GJ_Estado_Aventura_Put(
                tb,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
