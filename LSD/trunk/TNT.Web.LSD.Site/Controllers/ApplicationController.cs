using System;
using System.Web.Http;
using TNT.Web.LSD.DAL;
using TNT.Web.LSD.Models;

namespace TNT.Web.LSD.Site.Controllers
{
	public class ApplicationController : ApiController
	{
		public Response<Application> Post(Application application)
		{
			try
			{
				Application app = ApplicationDAL.Create(application);
				return new Response<Application>(app);
			}
			catch (Exception ex)
			{
				return new Response<Application>(ex.Message);
			}
		}

		public Response<Application> Get(string id)
		{
			try
			{
				Application app = ApplicationDAL.GetApplication(new Guid(id));

				if (app == null)
				{
					return new Response<Application>(string.Format("'{0}' is not a valid Appliation ID", id));
				}
				else
				{
					return new Response<Application>(app);
				}
			}
			catch(Exception ex)
			{
				return new Response<Application>(ex.Message);
			}
		}
	}
}
