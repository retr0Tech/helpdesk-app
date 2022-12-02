using System;
namespace helpdesk_app.core.Entities
{
	public class Ticket
	{
		public int TicketId { get; set; }
		public string NameOfDevice { get; set; }
		public string Brand { get; set; }
		public string Description { get; set; }
		public string TicketOwner { get; set; }
		public string Origin { get; set; }
		public string Status { get; set; }
    }
}

