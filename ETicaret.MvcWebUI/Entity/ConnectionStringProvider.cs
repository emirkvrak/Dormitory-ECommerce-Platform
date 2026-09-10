using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace ETicaret.MvcWebUI.Entity
{
    public static class ConnectionStringProvider
    {
        public static string GetConnectionString()
        {
            var configured = ConfigurationManager.ConnectionStrings["dataConnection"].ConnectionString;
            var password = Environment.GetEnvironmentVariable("MSSQL_SA_PASSWORD") ?? ReadDotEnvPassword();

            if (string.IsNullOrWhiteSpace(password))
            {
                return configured;
            }

            var builder = new SqlConnectionStringBuilder(configured)
            {
                Password = password
            };

            return builder.ConnectionString;
        }

        private static string ReadDotEnvPassword()
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            for (var level = 0; directory != null && level < 5; level++, directory = directory.Parent)
            {
                var envPath = Path.Combine(directory.FullName, ".env");

                if (!File.Exists(envPath))
                {
                    continue;
                }

                foreach (var line in File.ReadAllLines(envPath))
                {
                    var trimmed = line.Trim();

                    if (trimmed.StartsWith("MSSQL_SA_PASSWORD=", StringComparison.OrdinalIgnoreCase))
                    {
                        return trimmed.Substring("MSSQL_SA_PASSWORD=".Length).Trim().Trim('"');
                    }
                }
            }

            return null;
        }
    }
}
