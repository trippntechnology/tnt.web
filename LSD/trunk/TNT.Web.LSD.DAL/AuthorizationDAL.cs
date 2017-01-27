using System;
using System.Text;
using TNT.Data.Tools;
using TNT.Web.LSD.Models;

namespace TNT.Web.LSD.DAL
{
	/// <summary>
	/// Data abstraction for Authorization records
	/// </summary>
	public class AuthorizationDAL : DALBase
	{
		/// <summary>
		/// Gets an authorization key for a given hardware ID, application ID, and license key
		/// </summary>
		/// <param name="hardwareID">Hardware ID</param>
		/// <param name="appID">Application ID</param>
		/// <param name="licenseKey">License key</param>
		/// <returns>Authorization key if parameters are valid, string.Empty otherwise</returns>
		public static string GetAuthorizationKey(string hardwareID, Guid appID, string licenseKey)
		{
			string authKey = string.Empty;

			if (string.IsNullOrEmpty(hardwareID))
			{
				throw new Exception("Hardware ID is missing");
			}
			else if (string.IsNullOrEmpty(licenseKey))
			{
				throw new Exception("License key is missing");
			}

			Application app = ApplicationDAL.GetApplication(appID);

			if (app == null)
			{
				throw new Exception(string.Format("'{0}' is not a valid Appliation ID", appID.ToString()));
			}

			License license = LicenseDAL.GetLicense(licenseKey, appID);

			if (license == null)
			{
				throw new Exception("The license key is not valid for this application");
			}

			if (license != null)
			{
				// Create Authorization key
				string seed = string.Concat(hardwareID, appID.ToString(), licenseKey);
				authKey = Utilities.Registration.GenerateSHA1Hash(seed);
			}

			InsertAuthorization(authKey, licenseKey, hardwareID);

			return authKey;
		}

		/// <summary>
		/// Creates an authorization record
		/// </summary>
		/// <param name="authKey">Authentication key</param>
		/// <param name="licenseKey">License key</param>
		/// <param name="hardwareID">Hardware ID</param>
		private static void InsertAuthorization(string authKey, string licenseKey, string hardwareID)
		{
			using (QueryHelper qh = CreateQueryHelper())
			{
				StringBuilder query = new StringBuilder();

				query.AppendFormat("insert into Authorizations values('{0}','{1}','{2}','{3}')", authKey, licenseKey, hardwareID, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));

				qh.ExecuteQuery(query.ToString(), System.Data.CommandType.Text);
			}
		}
	}
}
