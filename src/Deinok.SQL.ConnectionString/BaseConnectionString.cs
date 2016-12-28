namespace Deinok.SQL.ConnectionString {

	public abstract class BaseConnectionString : IConnectionString{

		[ConnectionStringSerializeName("Host")]
		public string Host { get; set; }

		[ConnectionStringSerializeName("Port")]
		public int? Port { get; set; }

		[ConnectionStringSerializeName("Database")]
		public string Database { get; set; }

		[ConnectionStringSerializeName("UserId")]
		public string UserId { get; set; }

		[ConnectionStringSerializeName("Password")]
		public string Password { get; set; }

		public abstract string GenerateConnectionString();

	}

}
