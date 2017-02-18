using System;
using System.Threading;
using System.Threading.Tasks;
using Ofl.Configuration.Contracts;

namespace Ofl.Configuration
{
    public static class ConnectionStringManagerExtensions
    {
        // The default connection string.
        // NOTE: DefaultConnection influenced by sample at https://docs.asp.net/en/latest/fundamentals/configuration.html
        public static readonly string DefaultConnectionStringName = "DefaultConnection";

        public static Task<string> GetDefaultConnectionStringAsync(
            this IConnectionStringManager connectionStringManager,
            CancellationToken cancellationToken)
        {
            // Validate parameters.
            if (connectionStringManager == null) throw new ArgumentNullException(nameof(connectionStringManager));

            // Get the default connection string.
            return connectionStringManager.GetConnectionStringAsync(DefaultConnectionStringName, cancellationToken);
        }
    }
}
