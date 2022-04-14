using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
	[Table("Customer")]
	public class Customer
	{
		public int ID { get; set; }

		[Required(ErrorMessage = "Please enter your first name")]
		[StringLength(30)]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Please enter your last name")]
		[StringLength(30)]
		public string LastName { get; set; }
		// Regular exression inspiration from stack exchange and my team member Brett : )
		[Required(ErrorMessage = "Please enter your phone number with dashes and no parentheses")]
		[StringLength(15)]
		[DataType(DataType.PhoneNumber)]
		[RegularExpression(@"^([0-9]{3})[\-]([0-9]{3})[\-]([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
		public string Phone { get; set; }

		[Required(ErrorMessage = "Please enter a city")]
		[StringLength(30)]
		public string City { get; set; }

		[Required(ErrorMessage = "Please enter a username")]
		[StringLength(30)]
		public string Username { get; set; }

		[Required(ErrorMessage = "Please enter a password")]
		[StringLength(30)]
		public string Password { get; set; }

		// navigation property
		public virtual ICollection<Lease> Leases { get; set; }
	}
}
