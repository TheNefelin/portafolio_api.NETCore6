using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("tecnologias")]
    [ApiController]
    public class TecnologiasController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<TecnologiasController> _logger;

        public TecnologiasController(
            ConexionBDContext context,
            ILogger<TecnologiasController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> PA_Tecnologias_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Tecnologias_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
