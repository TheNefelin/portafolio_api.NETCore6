using Dapper;
using System.Data;
using System.Data.SqlClient;

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

        //-- Links Grupo --------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Links_Group_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_Links_Group_GetAll",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Links --------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Links_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_Links_GetAll",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        public async Task<dynamic> PA_Links_GetById(
            int id,
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_Links_GetById @{nameof(id)}",
                    new { id },
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }

        //-- Tecnologias --------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------
        public async Task<IEnumerable<dynamic>> PA_Tecnologias_GetAll(
            IDbConnection conexion,
            IDbTransaction? transaccion,
            CancellationToken cancelarToken)
        {
            var r = await conexion.QueryAsync(
                new CommandDefinition(
                    $"pa_Tecnologias_GetAll",
                    transaction: transaccion,
                    cancellationToken: cancelarToken));

            return r;
        }
    }
}
