using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public class Product(int id, string name, decimal unitPrice, int unitsInStock)
	{
		public int Id { get; set; } = id;
		public string Name { get; set; } = name;
		public decimal UnitPrice { get; set; } = unitPrice;
		public int UnitsInStock { get; set; } = unitsInStock;

		
	}
}
