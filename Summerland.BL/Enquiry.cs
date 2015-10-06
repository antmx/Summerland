using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Summerland.BL
{
	/// <summary>
	/// Represents an enquiry that has been made, e.g. by a website visitor.
	/// </summary>
	public class Enquiry : IValidatableObject
	{
		public DateTime Date
		{
			get;
			set;
		}

		[Required(ErrorMessage = "First Name is required")]
		[Display(Name = "First name", Prompt = "Your first name")]
		public string FirstName
		{
			get;
			set;
		}

		[Required(ErrorMessage = "Surname is required")]
		[Display(Name = "Surname", Prompt = "Your surname")]
		public string Surname
		{
			get;
			set;
		}

		//[Required(ErrorMessage = "Phone number or email are required")]
		[Display(Name = "Phone number", Prompt = "Your phone number")]
		public string TelNum
		{
			get;
			set;
		}

		//[Required(ErrorMessage = "Phone number or email are required")]
		[RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "A valid e-mail address is required")]
		[Display(Name = "Email", Prompt = "Your email address")]
		[DataType(DataType.EmailAddress)]
		public string Email
		{
			get;
			set;
		}

		[Required(ErrorMessage = "Message is required")]
		[Display(Name = "Message", Prompt = "Type your message")]
		[DataType(DataType.MultilineText)]
		public string Message
		{
			get;
			set;
		}

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (string.IsNullOrWhiteSpace(TelNum) && string.IsNullOrWhiteSpace(Email))
			{
				yield return new ValidationResult("Contact Phone Number or Email Address must be supplied.", new[] { "TelNum", "Email" });
			}
		}
	}
}
