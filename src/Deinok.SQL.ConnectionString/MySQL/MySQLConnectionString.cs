namespace Deinok.SQL.ConnectionString.MySQL {

	public class MySQLConnectionString : BaseConnectionString{

		public override string GenerateConnectionString() {
			return ConnectionStringSerializer.Serialize(this);
		}
	}
}
