namespace Deinok.SQL.ConnectionString {

	/// <summary>
	/// Interface for a Connection String
	/// </summary>
	public interface IConnectionString {

		/// <summary>
		/// Generate a ConnectionString ready for use
		/// </summary>
		/// <returns>The Connection String</returns>
		string GenerateConnectionString();
	}
}
