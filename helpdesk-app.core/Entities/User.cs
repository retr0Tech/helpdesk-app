using System;
namespace helpdesk_app.core.Entities
{
	public class User
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string UserEmail	{ get; set; }
	}
}

