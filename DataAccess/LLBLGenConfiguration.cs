using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Diagnostics;

namespace DataAccess
{
    /// <summary>
    ///  This class sets up the connection for LLBLGen.
    /// </summary>
    public static class LLBLGenConfiguration
    {
        /// <summary>
        /// Sets up the connection to LLBLGen
        /// http://llblgen.com/Documentation/5.3/LLBLGen%20Pro%20RTF/Using%20the%20generated%20code/gencode_runtimeconfiguration.htm
        /// </summary>
        /// <param name="databaseConnection"></param>
        public static void Setup(string databaseConnection)
        {
            RuntimeConfiguration.AddConnectionString("ConnectionString.SQL Server (SqlClient)", databaseConnection);

            RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(
                                c => c.SetTraceLevel(TraceLevel.Verbose)
                                        .AddDbProviderFactory(typeof(System.Data.SqlClient.SqlClientFactory))
                                        .SetDefaultCompatibilityLevel(SqlServerCompatibilityLevel.SqlServer2012));

            RuntimeConfiguration.Tracing
                                    .SetTraceLevel("ORMPersistenceExecution", TraceLevel.Verbose)
                        .SetTraceLevel("ORMPlainSQLQueryExecution", TraceLevel.Verbose);
        }
    }
}
