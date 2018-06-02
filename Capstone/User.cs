using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone {
	class User {
		//set properties for User
		public int Id { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool IsAdmin { get; set; }
		public bool IsReviewer { get; set; }

		//create User
		public void CreateUser(int Id, string Name, string Username, string Password, string Phone, string Email, bool IsAdmin, bool IsReviewer) {
			User User = new User {
				Id = Id,
				Name = Name,
				Username = Username,
				Password = Password,
				Phone = Phone,
				Email = Email,
				IsAdmin = IsAdmin,
				IsReviewer = IsReviewer
			};
		}

		//create vendor
		public Vendor CreateVendor(string Name, string Code, string City, string State, string Zip, string Phone, string Email, bool Recommended) {
			Vendor Vendor = new Vendor {
				Name = Name,
				Code = Code,
				City = City,
				State = State,
				Zip = Zip,
				Phone = Phone,
				Email = Email,
				Recommended = Recommended
			};
			return Vendor;
		}
		//create purchaserequest
		public void CreatePurchaseRequestList(string Description, string Justification, DateTime DateNeeded, string DeliveryMode, string Status, double Total) {
			PurchaseRequestList PurchaseRequestList = new PurchaseRequestList() {
				Description = Description,
				Justification = Justification,
				DateNeeded = DateNeeded,
				DeliveryMode = DeliveryMode,
				Status = Status,
				Total = Total
			};
		}
	}
}
