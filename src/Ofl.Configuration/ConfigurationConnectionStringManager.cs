using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Ofl.Configuration
{
    public class ConfigurationConnectionStringManager : IConnectionStringManager
    {
        #region Constructor.

        public ConfigurationConnectionStringManager(IConfiguration configuration)
        {
            // Validate parameters.
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        #endregion

        #region Instance, read-only state.

        private readonly IConfiguration _configuration;

        #endregion

        #region Implementation of IConnectionStringManager

        public Task<string> GetConnectionStringAsync(string name, CancellationToken cancellationToken)
        {
            // Validate parameters.
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));

            // Get the connection string from the name.
            return Task.FromResult(_configuration.GetConnectionString(name));
        }

        #endregion
    }
}
