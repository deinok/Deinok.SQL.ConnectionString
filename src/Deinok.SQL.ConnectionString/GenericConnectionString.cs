namespace Deinok.SQL.ConnectionString {

	public class GenericConnectionString : BaseConnectionString{

		public override string GenerateConnectionString() {
			return ConnectionStringSerializer.Serialize(this);
		}

	}
}
