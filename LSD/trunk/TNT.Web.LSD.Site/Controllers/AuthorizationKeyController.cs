using System;
using System.Web.Http;
using TNT.Web.LSD.DAL;
using TNT.Web.LSD.Models;

namespace TNT.Web.LSD.Site.Controllers
{
	public class AuthorizationKeyController : ApiController
	{
		public Response<string> Post(AuthorizationKeyRequest request)
		{
			try
			{
				string key = AuthorizationDAL.GetAuthorizationKey(request.HardwareID, request.ApplicationID, request.LicenseKey);
				return new Response<string>(true, key);
			}
			catch (Exception ex)
			{
				return new Response<string>(ex.Message);
			}
		}
	}
}
