using System;
using System.Collections.Generic;
using System.Reflection;


namespace Deinok.SQL.ConnectionString {

	public static class ConnectionStringSerializer {

		public static string Serialize<T>(T connectionString) where T : BaseConnectionString {
			string result=String.Empty;
			IEnumerable<PropertyInfo> properties = GetProperties<T>(connectionString);
			foreach (PropertyInfo property in properties) {
				string key = GetSerializeKey(property);
				string value = GetSerializeValue<T>(property,connectionString);
				result += GenerateKeyValue(key, value);
			}
			return result;
		}

		private static string GenerateKeyValue(string key, string value) {
			if (value != null) {
				return String.Format("{0}={1};", key, value);
			}
			return String.Empty;
		}

		private static string GenerateKeyValue(string key, int? value) {
			if (value != null) {
				return GenerateKeyValue(key, value.ToString());
			}
			return String.Empty;
		}

		private static string GenerateKeyValue(string key, bool? value) {
			if (value != null) {
				return GenerateKeyValue(key, value.ToString().ToLower());
			}
			return String.Empty;
		}

		private static IEnumerable<PropertyInfo> GetProperties<T>(T connectionString) where T : BaseConnectionString {
			return typeof(T).GetRuntimeProperties();
		}

		private static string GetSerializeKey(PropertyInfo propertyInfo) {
			ConnectionStringSerializeNameAttribute connectionStringSerializeNameAttribute = propertyInfo.GetCustomAttribute<ConnectionStringSerializeNameAttribute>();
			if (connectionStringSerializeNameAttribute == null) {
				return propertyInfo.Name;
			}
			return connectionStringSerializeNameAttribute.name;
		}

		private static string GetSerializeValue<T>(PropertyInfo propertyInfo, T connectionString) where T : BaseConnectionString {
			object result = propertyInfo.GetValue(connectionString);
			if (result == null) {
				return null;
			}

			Type resultType = result.GetType();

			if(resultType.Name == typeof(string).Name) {
				return ((string)result);
			}else if (resultType.Name == typeof(int).Name) {
				return ((int)result).ToString();
			}else if(resultType.Name== typeof(bool).Name) {
				return ((bool)result).ToString().ToLower();
			}

			return result.ToString();
			
		}
	}
}
