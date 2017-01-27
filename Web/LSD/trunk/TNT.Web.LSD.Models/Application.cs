using System;

namespace TNT.Web.LSD.Models
{
	/// <summary>
	/// Represents an application record
	/// </summary>
	public class Application
	{
		/// <summary>
		/// Application's ID
		/// </summary>
		public Guid ID { get; set; }

		/// <summary>
		/// Application name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Application version
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Application URL
		/// </summary>
		public Uri URL { get; set; }

		public override bool Equals(object obj)
		{
			Application app = obj as Application;

			if (app == null)
			{
				return false;
			}

			return this.ID.ToString() == app.ID.ToString() && this.Name == app.Name && this.Version == app.Version && this.URL.ToString() == app.URL.ToString();
		}
	}
}
