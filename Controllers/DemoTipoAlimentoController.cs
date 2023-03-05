using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("demo-tipo-alimento")]
    [ApiController]
    public class DemoTipoAlimentoController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<DemoTipoAlimentoController> _logger;

        public DemoTipoAlimentoController(
            ConexionBDContext context,
            ILogger<DemoTipoAlimentoController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> PA_TipoAlimento_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_TipoAlimento_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IEnumerable<dynamic>> PA_TipoAlimento_GetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_TipoAlimento_GetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
