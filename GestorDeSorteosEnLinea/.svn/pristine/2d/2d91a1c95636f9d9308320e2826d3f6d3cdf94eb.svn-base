using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GestorDeSorteosEnLinea.Model
{
	public class AspNetUsers
	{
		public string Id { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[EmailAddress]
		public Boolean EmailConfirmed { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string PasswordHash { get; set; }

		public string SecurityStamp { get; set; }
		public string PhoneNumber { get; set; }

		[Required]
		public Boolean PhoneNumberConfirmed { get; set; }

		[Required]
		public Boolean TwoFactorEnabled { get; set; }
		public DateTime? LockoutEndDateUtc { get; set; }

		[Required]
		public Boolean LockoutEnabled { get; set; }

		[Required]
		public int AccessFailedCount { get; set; }

		[Required]
		public string UserName { get; set; }

	}
}
