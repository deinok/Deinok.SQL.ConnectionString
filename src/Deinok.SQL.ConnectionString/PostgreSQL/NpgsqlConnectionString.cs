namespace Deinok.SQL.ConnectionString.PostgreSQL {

	/// <summary>
	/// https://www.connectionstrings.com/npgsql/
	/// </summary>
	public class NpgsqlConnectionString : BaseConnectionString{

		public override string GenerateConnectionString() {
			string result = "";

			result += this.GenerateKeyValue("Server", this.Host);
			result += this.GenerateKeyValue("Port", this.Port);
			result += this.GenerateKeyValue("Database", this.Database);
			result += this.GenerateKeyValue("User Id", this.UserId);
			result += this.GenerateKeyValue("Password", this.Password);

			return result;
		}

	}
}
