using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deinok.SQL.ConnectionString.MySQL{

    public class MySQLConnectionString : BaseConnectionString{

		public override string GenerateConnectionString() {
			string result = "";

			result += this.GenerateKeyValue("Database", this.Database);
			result += this.GenerateKeyValue("Server", this.Host);
			result += this.GenerateKeyValue("Port", this.Port);
			result += this.GenerateKeyValue("Uid", this.UserId);
			result += this.GenerateKeyValue("Pwd", this.Password);

			return result;
		}
	}
}
