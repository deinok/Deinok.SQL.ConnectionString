using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Deinok.SQL.ConnectionString;
using Deinok.SQL.ConnectionString.PostgreSQL;
using Xunit;

namespace Deinok.SQL.ConnectionString.Tests.PostgreSQL{

    public class NpgsqlConnectionStringTest{

		[Fact]
		public void StandardTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host="127.0.0.1",
				Port=5432,
				Database="myDataBase",
				UserId="myUsername",
				Password="myPassword"
			};

			Assert.Equal(
				"Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername; Password = myPassword; ", 
				connectionString.GenerateConnectionString()
			);
		}

    }
}
