using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone {
	class Vendor {

		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool Recommended { get; set; }
		public List<Product> Products = new List<Product>();

		public Product CreateProduct(string Name, string VendorPartNumber, double Price, string Unit, string PhotoPath, Vendor Vendor) {
			Product Product = new Product {
				Name = Name,
				VendorPartNumber = VendorPartNumber,
				Price = Price,
				Unit = Unit,
				PhotoPath = PhotoPath,
				Vendor = Vendor
			};
			return Product;
		}
	}
}
