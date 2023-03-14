using Microsoft.AspNetCore.Mvc;
using portafolio_api.NETCore6.Connection;

namespace portafolio_api.NETCore6.Controllers
{
    //[ApiKeyAuth]
    [Route("demo-item")]
    [ApiController]
    public class DemoItemController : Controller
    {
        private readonly ConexionBDContext _context;
        private readonly ILogger<DemoItemController> _logger;

        public DemoItemController(
            ConexionBDContext context,
            ILogger<DemoItemController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<dynamic>> pa_Item_GetAll(
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.pa_Item_GetAll(
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<dynamic> PA_Item_GetById(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Item_GetById(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("IdCateg/{id:int}")]
        public async Task<IEnumerable<dynamic>> PA_Item_GetByIdCateg(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Item_GetByIdCateg(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }

        [HttpGet]
        [Route("IdNegocio/{id:int}")]
        public async Task<IEnumerable<dynamic>> PA_Item_GetByIdNegocio(
            int id,
            CancellationToken cancelarToken)
        {
            var conexion = _context.CreateConnection();

            var r = await _context.PA_Item_GetByIdNegocio(
                id,
                conexion,
                default,
                cancelarToken);

            return r;
        }
    }
}
