namespace Deinok.SQL.ConnectionString {

	public class GenericConnectionString : BaseConnectionString{

		public override string GenerateConnectionString() {
			string result = "";

			result += this.GenerateKeyValue("Database", this.Database);
			result += this.GenerateKeyValue("Server", this.Host);
			result += this.GenerateKeyValue("Port", this.Port);
			result += this.GenerateKeyValue("UserId", this.UserId);
			result += this.GenerateKeyValue("Password", this.Password);

			return result;
		}

	}
}
