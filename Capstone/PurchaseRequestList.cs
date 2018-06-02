using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone {
	class PurchaseRequestList {

		public int Id { get; set; }
		public string Description { get; set; }
		public string Justification { get; set; }
		public DateTime DateNeeded { get; set; }
		public string DeliveryMode { get; set; }
		public string Status { get; set; }
		public double Total { get; set; }
		public User User { get; set; }
		public bool DocsAttached { get; set; }

	}
}
