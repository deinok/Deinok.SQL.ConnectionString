using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deinok.SQL.ConnectionString {

    public interface IConnectionString {

		string Database { get; set; }

		string Host { get; set; }

		int ?Port { get; set; }

		string UserId { get; set; }

		string Password { get; set; }

		string GenerateConnectionString();
	}
}
