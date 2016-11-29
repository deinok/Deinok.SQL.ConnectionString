using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deinok.SQL.ConnectionString{
    public abstract class BaseConnectionString:IConnectionString{

		public string Database { get; set; }

		public string Host { get; set; }

		public int? Port { get; set; }

		public string UserId { get; set; }

		public string Password { get; set; }

		public abstract string GenerateConnectionString();

	}
}
