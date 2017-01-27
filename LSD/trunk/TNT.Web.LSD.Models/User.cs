using System;

namespace TNT.Web.LSD.Models
{
	/// <summary>
	/// Represents a user associated with a license
	/// </summary>
	public class User
	{
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Email address
		/// </summary>
		public string EmailAddress { get; set; }

		/// <summary>
		/// Street address
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// City
		/// </summary>
		public string City { get; set; }

		/// <summary>
		/// State
		/// </summary>
		public string State { get; set; }

		/// <summary>
		/// Zip code
		/// </summary>
		public string Zip { get; set; }

		/// <summary>
		/// Phone number
		/// </summary>
		public string PhoneNumber { get; set; }

		public override bool Equals(object obj)
		{
			User user = obj as User;

			if (user == null)
			{
				return false;
			}

			return this.Name == user.Name && this.EmailAddress == user.EmailAddress && this.Address == user.Address &&
							this.City == user.City && this.State == user.State && this.Zip == user.Zip && this.PhoneNumber == user.PhoneNumber;
		}
	}
}
