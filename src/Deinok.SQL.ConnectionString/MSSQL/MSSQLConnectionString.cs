namespace Deinok.SQL.ConnectionString.MSSQL {

	public class MSSQLConnectionString : BaseConnectionString{

		public override string GenerateConnectionString() {
			return ConnectionStringSerializer.Serialize(this);
		}

	}
}
