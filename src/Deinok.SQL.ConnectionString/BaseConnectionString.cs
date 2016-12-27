﻿using System;
using System.Reflection;
using System.Collections.Generic;

namespace Deinok.SQL.ConnectionString {

	public abstract class BaseConnectionString : IConnectionString{

		public string Host { get; set; }

		public int? Port { get; set; }

		public string Database { get; set; }

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

		protected internal string GenerateKeyValue(string key,bool? value) {
			if (value != null) {
				return String.Format("{0}={1};", key, value.ToString().ToLower());
			}
			return String.Empty;
		}

	}

}
