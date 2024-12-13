using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
	public abstract class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public abstract decimal CalculateMonthlyPayment();
		public virtual int GetPaymentDays()
		{
			return 10;
		}
	}

	public class Secretary : Employee
	{
		public override decimal CalculateMonthlyPayment() => 15000;
	}

	public class Manager : Employee
	{
		public override decimal CalculateMonthlyPayment() => 45000;
	}

	public class Developer : Employee
	{
		public override decimal CalculateMonthlyPayment() => 30000;

		public override int GetPaymentDays()
		{
			return 20;
		}
	}
}
