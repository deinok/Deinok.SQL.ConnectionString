using System;

namespace Deinok.SQL.ConnectionString.PostgreSQL {

	/// <summary>
	/// https://www.connectionstrings.com/npgsql/
	/// </summary>
	public class NpgsqlConnectionString : BaseConnectionString{

		public bool? IntegratedSecurity { get; set; }
		public int? CommandTimeout { get; set; }
		public int? ConnectionTimeout { get; set; }
		public int? Protocol { get; set; }
		public bool? SSL { get; set; }
		public SslMode? SSLMode { get; set; }
		public bool? Pooling { get; set; }
		public int? MinPoolSize { get; set; }
		public int? MaxPoolSize { get; set; }
		public int? ConnectionLifeTime { get; set; }

		public override string GenerateConnectionString() {
			string result = "";

			result += this.GenerateKeyValue("Server", this.Host);
			result += this.GenerateKeyValue("Port", this.Port);
			result += this.GenerateKeyValue("Database", this.Database);
			result += this.GenerateKeyValue("User Id", this.UserId);
			result += this.GenerateKeyValue("Password", this.Password);
			result += this.GenerateKeyValue("Integrated Security", this.IntegratedSecurity);
			result += this.GenerateKeyValue("CommandTimeout", this.CommandTimeout);
			result += this.GenerateKeyValue("Timeout", this.ConnectionTimeout);
			result += this.GenerateKeyValue("Protocol", this.Protocol);
			result += this.GenerateKeyValue("SSL", this.SSL);
			if (this.SSLMode != null) {
				result += String.Format("{0}={1};", "SslMode", this.SSLMode.ToString());
			}

			result += this.GenerateKeyValue("Pooling", this.Pooling);
			result += this.GenerateKeyValue("MinPoolSize", this.MinPoolSize);
			result += this.GenerateKeyValue("MaxPoolSize", this.MaxPoolSize);
			result += this.GenerateKeyValue("ConnectionLifeTime", this.ConnectionLifeTime);

			return result;
		}

		public enum SslMode{
			Require,
			Disable
		}

	}
}
