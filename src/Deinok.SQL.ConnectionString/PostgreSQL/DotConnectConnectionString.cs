namespace Deinok.SQL.ConnectionString.PostgreSQL {

	/// <summary>
	/// https://www.connectionstrings.com/dotconnect-for-postgresql/
	/// </summary>
	public class DotConnectConnectionString : BaseConnectionString {

		[ConnectionStringSerializeName("Host")]
		public new string Host { get; set; }

		[ConnectionStringSerializeName("Port")]
		public new int? Port { get; set; }

		[ConnectionStringSerializeName("Database")]
		public new string Database { get; set; }

		[ConnectionStringSerializeName("User ID")]
		public new string UserId { get; set; }

		[ConnectionStringSerializeName("Password")]
		public new string Password { get; set; }

		[ConnectionStringSerializeName("Pooling")]
		public bool? Pooling { get; set; }

		[ConnectionStringSerializeName("Min Pool Size")]
		public int? MinPoolSize { get; set; }

		[ConnectionStringSerializeName("Max Pool Size")]
		public int? MaxPoolSize { get; set; }

		[ConnectionStringSerializeName("Connection Lifetime")]
		public int? ConnectionLifeTime { get; set; }

		public override string GenerateConnectionString() {
			return ConnectionStringSerializer.Serialize(this);
		}

	}
}
