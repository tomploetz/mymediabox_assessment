using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyMediaboxAssessment.Classes
{
	public class Calculations
	{
		//calculate gross sales
		public double CalculateGrossSales(double toysSold, double price)
		{
			double result = 0;

			result = toysSold * price;

			return result;
		}

		//calculate net sales
		public double CalculateNetSales(double gross, double toysReturned, double price, double discounts)
		{
			double result = 0;

			result = gross - (toysReturned * price) - discounts;

			return result;
		}

		//calculate royalties paid
		public double CalculateRoyalties(double net, double royalty)
		{
			double result = 0;

			result = net * royalty;

			return result;
		}

		public double CalculateReturnRate(double returned, double totalSold)
		{
			double result = 0;

			result = returned / totalSold;

			return result;
		}

		public double CalculateCommission(double royalties, double rate)
		{
			double result = 0;

			result = royalties * rate;

			return result;
		}
	}
}
