using System;

namespace Deinok.SQL.ConnectionString {

	[AttributeUsage(AttributeTargets.Property)]
	public class ConnectionStringSerializeNameAttribute : System.Attribute {

		public readonly string name;

		public ConnectionStringSerializeNameAttribute(string name) {
			this.name = name;
		}

	}

}
