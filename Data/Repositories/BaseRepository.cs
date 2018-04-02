using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace DevAngular.Data.Repositories
{
    public class BaseRepository : IDisposable
    {
        protected OracleConnection connnection;
        protected OracleCommand command;

        public BaseRepository()
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.0.1.10)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=PBAS))); User Id=ACSELSEP;Password=SUPERUSRPBAS";  
            connnection = new OracleConnection(connectionString);
            command = new OracleCommand
            {
                CommandType = CommandType.StoredProcedure,
                Connection = connnection
            };
        }

        public void Dispose()
        {
            connnection.Dispose();
            command.Dispose();
        }
    }

}
