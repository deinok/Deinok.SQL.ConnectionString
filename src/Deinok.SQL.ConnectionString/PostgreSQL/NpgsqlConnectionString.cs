namespace Deinok.SQL.ConnectionString.PostgreSQL {

	/// <summary>
	/// https://www.connectionstrings.com/npgsql/
	/// </summary>
	public class NpgsqlConnectionString : BaseConnectionString{

		[ConnectionStringSerializeName("Server")]
		public new string Host { get; set; }

		[ConnectionStringSerializeName("Port")]
		public new int? Port { get; set; }

		[ConnectionStringSerializeName("Database")]
		public new string Database { get; set; }

		[ConnectionStringSerializeName("User Id")]
		public new string UserId { get; set; }

		[ConnectionStringSerializeName("Password")]
		public new string Password { get; set; }

		[ConnectionStringSerializeName("Integrated Security")]
		public bool? IntegratedSecurity { get; set; }

		[ConnectionStringSerializeName("CommandTimeout")]
		public int? CommandTimeout { get; set; }

		[ConnectionStringSerializeName("Timeout")]
		public int? ConnectionTimeout { get; set; }

		[ConnectionStringSerializeName("Protocol")]
		public int? Protocol { get; set; }

		[ConnectionStringSerializeName("SSL")]
		public bool? SSL { get; set; }

		[ConnectionStringSerializeName("SslMode")]
		public SslMode? SSLMode { get; set; }

		[ConnectionStringSerializeName("Pooling")]
		public bool? Pooling { get; set; }

		[ConnectionStringSerializeName("MinPoolSize")]
		public int? MinPoolSize { get; set; }

		[ConnectionStringSerializeName("MaxPoolSize")]
		public int? MaxPoolSize { get; set; }

		[ConnectionStringSerializeName("ConnectionLifeTime")]
		public int? ConnectionLifeTime { get; set; }

		public override string GenerateConnectionString() {
			return ConnectionStringSerializer.Serialize<NpgsqlConnectionString>(this);
		}

		public enum SslMode{
			Require,
			Disable
		}

	}
}
