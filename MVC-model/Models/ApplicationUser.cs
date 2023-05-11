﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MVC_model.Models
{
	[Keyless]
	public class ApplicationUser : IdentityUser
	{

		public string Fristname { get; set; }
		public string Lastname { get; set; }
		public string Address { get; set; }
		public string Phone { get; set; }
	}
}
