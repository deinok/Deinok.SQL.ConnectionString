using System;

namespace Deinok.SQL.ConnectionString {

	public abstract class BaseConnectionString : IConnectionString{

		public string Database { get; set; }

		public string Host { get; set; }

		public int? Port { get; set; }

		public string UserId { get; set; }

		public string Password { get; set; }

		public abstract string GenerateConnectionString();

		protected internal string GenerateKeyValue(string key,string value) {
			if (value != null) {
				return String.Format("{0}={1};", key, value);
			}
			return String.Empty;
		}

		protected internal string GenerateKeyValue(string key, int? value) {
			if (value != null) {
				return String.Format("{0}={1};", key, value);
			}
			return String.Empty;
		}

		[AttributeUsage(AttributeTargets.Property)]
		protected class ConnectionStringKeywordNameAttribute : System.Attribute {

			private readonly string keyword;

			public ConnectionStringKeywordNameAttribute(string keyword) {
				this.keyword = keyword;
			}

		}

	}

}
