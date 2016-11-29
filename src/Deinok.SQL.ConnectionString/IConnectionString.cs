namespace Deinok.SQL.ConnectionString {

	/// <summary>
	/// Interface for a Connection String
	/// </summary>
	public interface IConnectionString {

		/// <summary>
		/// Name of the Database
		/// </summary>
		string Database { get; set; }

		/// <summary>
		/// Name of the Host
		/// </summary>
		string Host { get; set; }

		/// <summary>
		/// Port of the Host
		/// </summary>
		int? Port { get; set; }

		/// <summary>
		/// User of the Database
		/// </summary>
		string UserId { get; set; }

		/// <summary>
		/// Password of the User
		/// </summary>
		string Password { get; set; }

		/// <summary>
		/// Generate a ConnectionString ready for use
		/// </summary>
		/// <returns>The Connection String</returns>
		string GenerateConnectionString();
	}
}
