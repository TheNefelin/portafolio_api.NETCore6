using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("demo-item-categ")]
    [ApiController]
    public class DemoItemCategController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<DemoItemCategController> _logger;

        public DemoItemCategController(
            ConexionBDContext context,
            ILogger<DemoItemCategController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> PA_ItemCateg_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_ItemCateg_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IEnumerable<dynamic>> PA_ItemCateg_GetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_ItemCateg_GetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
