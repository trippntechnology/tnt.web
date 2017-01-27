using System;
using System.Data;
using System.Data.Common;
using System.Text;
using TNT.Data.Tools;
using TNT.Web.LSD.Models;

namespace TNT.Web.LSD.DAL
{
	/// <summary>
	/// Data abstraction layer for Application records
	/// </summary>
	public class ApplicationDAL : DALBase
	{
		/// <summary>
		/// Gets the application record associated with the application ID
		/// </summary>
		/// <param name="appid">Application ID</param>
		/// <returns>Application record associated with the application ID</returns>
		public static Application GetApplication(Guid appid)
		{
			using (QueryHelper qh = CreateQueryHelper())
			{
				StringBuilder sql = new StringBuilder();

				sql.AppendFormat("select * from Applications where upper(ApplicationID) = upper('{0}')", appid.ToString());

				return qh.ExecuteQuery<Application>(sql.ToString(), System.Data.CommandType.Text, null, dr =>
					{
						Application appInfo = null;

						if (dr.Read())
						{
							appInfo = FillApplication(dr);
						}

						return appInfo;
					});
			}
		}

		/// <summary>
		/// Fills out an Application
		/// </summary>
		/// <param name="dr">Data reader</param>
		/// <returns>ApplicationInfo object representing the results in the data reader</returns>
		public static Application FillApplication(DbDataReader dr)
		{
			Application appInfo = new Application()
			{
				ID = (Guid)dr.GetGuid("ApplicationID"),
				Name = dr.GetString("Name"),
				Version = dr.GetString("Version"),
				URL = new Uri(dr.GetString("URL"))
			};

			return appInfo;
		}

		public static Application Create(Application application)
		{
			using (QueryHelper qh = CreateQueryHelper())
			{
				StringBuilder sql = new StringBuilder();

				sql.AppendFormat("insert into Applications (ApplicationID, Name, Version, URL) values ('{0}', '{1}', '{2}', '{3}')", application.ID.ToString(), application.Name, application.Version, application.URL.ToString());

				qh.ExecuteQuery(sql.ToString(), CommandType.Text);
			}

			return application;
		}
	}
}
