using Dapper;
using portafolio_api.NETCore6.Models;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace portafolio_api.NETCore6.Connection
{
    public class ConexionBDContext
    {
        private readonly string _RutaDeConexion;

        public ConexionBDContext(String RutaDeConexion)
        {
            _RutaDeConexion = RutaDeConexion;
        }

        public IDbConnection CreateConnection() => new SqlConnection(_RutaDeConexion);

        //-- Links Grupo List ---------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Links_Group_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_mae_links_grp_get",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Links List ---------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Links_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_mae_links_get",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Links --------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> Pa_GetAll_Links(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var groups = await conexion.QueryAsync<LinksGroup>(
                new CommandDefinition(
                    "pa_mae_links_grp_get",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            var links = await conexion.QueryAsync<Links>(
                new CommandDefinition(
                    "pa_mae_links_get",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            foreach (var link in links)
            {
                var group = groups.FirstOrDefault(g => g.Id == link.Id_link_grp);
                group?.Links.Add(link);
            }

            return groups;
        }

        //-- Guia Usuarios ------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<dynamic> GJ_Usuario_Post(
            GJ_Usuario tb,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryFirstOrDefaultAsync(
                new CommandDefinition(
                    $"pa_gj_Usuario_post @{nameof(tb.Usuario)}, @{nameof(tb.Token)}",
                    new { tb.Usuario, tb.Token },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> GJ_Estado_Guia_Put(
              GJ_UsuarioGuia tb,
              IDbConnection conexion,
              IDbTransaction? transaccion,
              CancellationToken cancelarToken)
        {
            var r = await conexion.QueryFirstOrDefaultAsync(
                new CommandDefinition(
                    $"pa_gj_guia_estado_put @{nameof(tb.Usuario)}, @{nameof(tb.Token)}, @{nameof(tb.Id_Guia)}, @{nameof(tb.Estado)}",
                    new { tb.Usuario, tb.Token, tb.Id_Guia, tb.Estado },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> GJ_Estado_Aventura_Put(
              GJ_UsuarioAventura tb,
              IDbConnection conexion,
              IDbTransaction? transaccion,
              CancellationToken cancelarToken)
        {
            var r = await conexion.QueryFirstOrDefaultAsync(
                new CommandDefinition(
                    $"pa_gj_aventura_estado_put @{nameof(tb.Usuario)}, @{nameof(tb.Token)}, @{nameof(tb.Id_Aventura)}, @{nameof(tb.Estado)}",
                    new { tb.Usuario, tb.Token, tb.Id_Aventura, tb.Estado },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Juegos --------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Juegos_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_juegos",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> GJ_Juegos_ById(
            int Id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_juegos_byid @{nameof(Id)}",
                    new { Id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Fuentes -------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Fuentes_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_fuentes",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> GJ_Fuentes_ByIdJuego(
            int Id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_fuentes_byid_juego @{nameof(Id)}",
                    new { Id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Background ----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Background_Img_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_background_img",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> GJ_Background_Img_ByIdJuego(
            int Id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_background_img_byid_juego @{nameof(Id)}",
                    new { Id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Personajes ----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Personajes_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_personajes",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> GJ_Personajes_ByIdJuego(
            int Id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_personajes_byid_juego @{nameof(Id)}",
                    new { Id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Guias ---------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Guias_GetAll(
            string User,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_guias @{nameof(User)}",
                    new { User },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> GJ_Guias_ByIdJuego(
            int IdJuego,
            string User,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_guias_byid_juego @{nameof(IdJuego)}, @{nameof(User)}",
                    new { IdJuego, User },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Aventuras -----------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Aventuras_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_aventuras",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> GJ_Aventuras_ByIdJuego(
            int IdJuego,
            string User,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_aventuras_byid_juego @{nameof(IdJuego)}, @{nameof(User)}",
                    new { IdJuego, User },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Guia Aventuras Img --------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> GJ_Aventuras_Img_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_aventuras_img",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<IEnumerable<dynamic>> GJ_Aventuras_Img_ByIdIdJuego(
            int IdJuego,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_gj_aventuras_img_byid_juego @{nameof(IdJuego)}",
                    new { IdJuego },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- - --------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------

        //-- - --------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
    }
}
