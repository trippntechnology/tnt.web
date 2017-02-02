using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using TNT.Web.LSD.Models;

namespace TNT.Web.LSD.Site.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			//Guid guid = Guid.NewGuid();

			//RestSharp.RestClient restClient = new RestSharp.RestClient("http://localhost:18782/api/");

			//Application app = new Application()
			//{
			//	Name = "Test Application",
			//	ID = guid,
			//	URL = new Uri("http://domain.com"),
			//	Version = "1.0.0.0"
			//};

			//// Create new appliation
			//Response<Application> postAppResponse = restClient.Post<Response<Application>>("Application/", app);
			//Assert.IsTrue(postAppResponse.Success);
			//Assert.IsNotNull(postAppResponse.Payload);

			//// Create same application
			//postAppResponse = restClient.Post<Response<Application>>("Application/", app);
			//Assert.IsFalse(postAppResponse.Success);
			//Assert.IsNull(postAppResponse.Payload);

			//Response<Application> getAppResponse = restClient.Get<Response<Application>>(string.Format("Application/{0}", app.ID.ToString()));
			//Assert.AreEqual(app, getAppResponse.Payload);

			//getAppResponse = restClient.Get<Response<Application>>("Application/InvalidID");
			//Assert.IsFalse(getAppResponse.Success);
			//Assert.AreEqual("Guid should contain 32 digits with 4 dashes (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).", getAppResponse.Message);

			//getAppResponse = restClient.Get<Response<Application>>("Application/AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA");
			//Assert.IsFalse(getAppResponse.Success);
			//Assert.AreEqual("'AAAAAAAA-AAAA-AAAA-AAAA-AAAAAAAAAAAA' is not a valid Appliation ID", getAppResponse.Message);

			//User user = new User()
			//{
			//	Address = "171 E Roylance Dr",
			//	City = "Draper",
			//	EmailAddress = "stevetripp@comcast.net",
			//	Name = "Steve Tripp",
			//	PhoneNumber = "801.656.8108",
			//	State = "Ut",
			//	Zip = "84020"
			//};

			//LicenseRequest lr = new LicenseRequest() { User = user };

			//lr.ApplicationID = new Guid("BBBBBBBB-BBBB-BBBB-BBBB-BBBBBBBBBBBB");
			//Response<License> licenseResponse = restClient.Post<Response<License>>("License", lr);
			//Assert.IsFalse(licenseResponse.Success);
			//Assert.AreEqual("'bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb' is not a valid Appliation ID", licenseResponse.Message);

			//licenseResponse = restClient.Post<Response<License>>("License", new LicenseRequest() { ApplicationID = app.ID });
			//Assert.IsFalse(licenseResponse.Success);
			//Assert.AreEqual("A user must be specified", licenseResponse.Message);

			//licenseResponse = restClient.Post<Response<License>>("License", new LicenseRequest() { ApplicationID = app.ID, User = new User() });
			//Assert.IsFalse(licenseResponse.Success);
			//Assert.AreEqual("User name must be specified", licenseResponse.Message);

			//licenseResponse = restClient.Post<Response<License>>("License", new LicenseRequest() { User = new User() { Name = "User Name" } });
			//Assert.IsFalse(licenseResponse.Success);
			//Assert.AreEqual("'00000000-0000-0000-0000-000000000000' is not a valid Appliation ID", licenseResponse.Message);

			//lr = new LicenseRequest() { ApplicationID = app.ID, User = user };
			//licenseResponse = restClient.Post<Response<License>>("License", lr);
			//Assert.IsTrue(licenseResponse.Success);

			//Assert.AreEqual(licenseResponse.Payload.Application, app);
			//Assert.AreEqual(licenseResponse.Payload.IssuedTo, user);
			//Assert.IsFalse(string.IsNullOrEmpty(licenseResponse.Payload.Key));
			//StringAssert.Matches(licenseResponse.Payload.Key, new Regex("([A-Z]{4}-){4}[A-Z]{4}"));

			//AuthorizationKeyRequest akr = new AuthorizationKeyRequest();

			//Response<string> keyResponse = restClient.Post<Response<string>>("AuthorizationKey", akr);
			//Assert.IsFalse(keyResponse.Success);
			//Assert.AreEqual("Hardware ID is missing", keyResponse.Message);

			//akr.HardwareID = "ABCDEFG";
			//keyResponse = restClient.Post<Response<string>>("AuthorizationKey", akr);
			//Assert.IsFalse(keyResponse.Success);
			//Assert.AreEqual("License key is missing", keyResponse.Message);

			//akr.LicenseKey = "AAAA-AAAA-AAAA-AAAA-AAAA";
			//keyResponse = restClient.Post<Response<string>>("AuthorizationKey", akr);
			//Assert.IsFalse(keyResponse.Success);
			//Assert.AreEqual("'00000000-0000-0000-0000-000000000000' is not a valid Appliation ID", keyResponse.Message);

			//akr.ApplicationID = app.ID;
			//keyResponse = restClient.Post<Response<string>>("AuthorizationKey", akr);
			//Assert.IsFalse(keyResponse.Success);
			//Assert.AreEqual("The license key is not valid for this application", keyResponse.Message);

			//akr = new AuthorizationKeyRequest() { ApplicationID = app.ID, HardwareID = "ABCDEFGHI", LicenseKey = licenseResponse.Payload.Key };
			//keyResponse = restClient.Post<Response<string>>("AuthorizationKey", akr);
			//Assert.IsTrue(keyResponse.Success);

			//Response<string> keyResponse2 = restClient.Post<Response<string>>("AuthorizationKey", akr);
			//Assert.AreEqual(keyResponse2.Payload, keyResponse.Payload);
		}
	}
}
