using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone {
	class Program {

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

		static void Main(string[] args) {

			User greg = new User() {
				Id = 1,
				Name = "Greg",
				Username = "gdoud",
				Password = "password",
				Phone = "513-444-4444",
				Email = "gdoud@max.com",
				IsAdmin = true,
				IsReviewer = true
			};

			Vendor amazon = greg.CreateVendor("Amazon", "AMZ", "West Chester", "OH", "45069", "513-444-4444", "thing@amazon.com", true);
			Product echo = amazon.CreateProduct("echo", "E201410", 49.99, "Each", "photopath", amazon);
			greg.CreatePurchaseRequestList("I need these things", "I am the greatest", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"), "UPS", "REVIEW", 49.99);

		}
	}
}
