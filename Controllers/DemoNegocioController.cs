using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("demo-negocio")]
    [ApiController]
    public class DemoNegocioController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<DemoNegocioController> _logger;

        public DemoNegocioController(
            ConexionBDContext context,
            ILogger<DemoNegocioController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> PA_Negocio_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Negocio_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<dynamic> PA_Negocio_GetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Negocio_GetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
