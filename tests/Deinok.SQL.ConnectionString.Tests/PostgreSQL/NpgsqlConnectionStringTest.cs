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

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected,actual);
		}

		[Fact]
		public void WindowsSecurityTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				IntegratedSecurity = true
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;Integrated Security=true;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void CommandTimeoutTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				UserId="myUsername",
				Password="myPassword",
				CommandTimeout = 20
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;CommandTimeout=20;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected,actual);
		}

		[Fact]
		public void ConnectionTimeoutTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				UserId = "myUsername",
				Password = "myPassword",
				ConnectionTimeout = 15
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;Timeout=15;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void ProtocolTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				UserId = "myUsername",
				Password = "myPassword",
				Protocol = 3
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;Protocol=3;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void SSLTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				UserId = "myUsername",
				Password = "myPassword",
				Protocol = 3,
				SSL=true ,
				SSLMode=NpgsqlConnectionString.SslMode.Require
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;Protocol=3;SSL=true;SslMode=Require;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void WithoutSSLTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				UserId = "myUsername",
				Password = "myPassword",
				Protocol = 3,
				SSL = false,
				SSLMode = NpgsqlConnectionString.SslMode.Disable
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;Protocol=3;SSL=false;SslMode=Disable;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void PoolingTest() {
			IConnectionString connectionString = new NpgsqlConnectionString() {
				Host = "127.0.0.1",
				Port = 5432,
				Database = "myDataBase",
				UserId = "myUsername",
				Password = "myPassword",
				Protocol = 3,
				Pooling= true,
				MinPoolSize=1,
				MaxPoolSize=20,
				ConnectionLifeTime=15
			};

			string expected = "Server=127.0.0.1;Port=5432;Database=myDataBase;User Id=myUsername;Password=myPassword;Protocol=3;Pooling=true;MinPoolSize=1;MaxPoolSize=20;ConnectionLifeTime=15;";
			string actual = connectionString.GenerateConnectionString();
			Assert.Equal(expected, actual);
		}

	}
}
