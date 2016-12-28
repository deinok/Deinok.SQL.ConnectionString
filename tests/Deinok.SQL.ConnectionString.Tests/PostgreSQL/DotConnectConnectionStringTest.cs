using Deinok.SQL.ConnectionString.PostgreSQL;
using Xunit;

namespace Deinok.SQL.ConnectionString.Tests.PostgreSQL {

	public class DotConnectConnectionStringTest{

		[Fact]
		public void StandardTest() {
			IConnectionString connectionString = new DotConnectConnectionString() {
				Host = "localhost",
				Port = 5432,
				Database = "myDataBase",
				UserId = "root",
				Password = "myPassword"	,
				Pooling=true,
				MinPoolSize=0,
				MaxPoolSize=100,
				ConnectionLifeTime=0
			};

			string expected = "Host=localhost;Port=5432;Database=myDataBase;User ID=root;Password=myPassword;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

	}
}
