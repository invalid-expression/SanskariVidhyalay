using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanskariVidhyalay.Models
{
	public class StudentEntries
	{
		[Key] public int StudentID { get; set; }

		[Column("First Name", TypeName = "Varchar(15)")]
		[Required]
		public string StudentFirstName { get; set; }

		[Column("Last Name", TypeName = "Varchar(15)")]
		[Required]
		public string StudentLastName { get; set; }

		[Required]
		public int Standard {  get; set; }

		[Required]
		public string Medium { get; set; }

		[Column("Date of Birth", TypeName = "Varchar(15)")]
		[Required]
		public string DateofBirth { get; set; }

		[Column("Mobile Number",TypeName = "Varchar(12)")]
		[Required]
		public string MobileNumber { get; set; }

		[Column("Alternative Mobile Number", TypeName = "Varchar(15)")]
		[Required]
		public string AlternativeMobileNumber { get; set; }

		[Column(TypeName = "Varchar(50)")]
		[Required]
		public string Address { get; set; }

		[Column(TypeName = "Varchar(20)")]
		[Required]
		public string City { get; set; }

		[Column(TypeName = "Varchar(15)")]
		[Required]
		public string Region { get; set; }


		[Column("Pin Code", TypeName = "int")]
		[Required]
		public int PostalCode { get; set; }

	}
}
