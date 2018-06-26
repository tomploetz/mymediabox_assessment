using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMediaboxAssessment.Classes;

namespace MyMediaboxAssessment
{
	class Program
	{
		static void Main(string[] args)
		{
			//create new Calculations object for calculation methods
			Calculations calc = new Calculations();

			#region Q1 Calculations
			//create new toy object for cowboy Q1 and populate
			Toy _cowboyQ1 = new Toy
			{
				Price = 8.98,
				Sold = 123569,
				Royalty = 0.045,
				Discounts = 68845.36,
				Returned = 3569
			};

			//declare variables for Q1
			double grossSalesQ1 = calc.CalculateGrossSales(_cowboyQ1.Sold, _cowboyQ1.Price);
			double netSalesQ1 = calc.CalculateNetSales(grossSalesQ1, _cowboyQ1.Returned, _cowboyQ1.Price, _cowboyQ1.Discounts);
			double royaltiesOnNetSalesQ1 = calc.CalculateRoyalties(netSalesQ1, _cowboyQ1.Royalty);

			//Q1 calculations
			Console.WriteLine("-----Q1 Calculations-----");
			Console.WriteLine($"Gross sales for Q1: {grossSalesQ1.ToString("c")}");
			Console.WriteLine($"Net sales for Q1: {netSalesQ1.ToString("c")}");
			Console.WriteLine($"Royalties paid for Q1: {royaltiesOnNetSalesQ1.ToString("c")}");
			Console.WriteLine();
			#endregion

			#region Q2 Calculations
			//create new objects for cowboy and horse for Q2 and populate
			Toy _cowboyQ2 = new Toy
			{
				Price = 8.98,
				Sold = 129747,
				Royalty = 0.045,
				Discounts = 72287.63,
				Returned = 3747
			};

			Toy _horseQ2 = new Toy
			{
				Price = 6.99,
				Sold = 62875,
				Royalty = 0.0348,
				Discounts = 16521.06,
				Returned = 1478
			};

			
			//declare variables for Q2
			double cowboyGrossSalesQ2 = calc.CalculateGrossSales(_cowboyQ2.Sold, _cowboyQ2.Price);
			double horseGrossSalesQ2 = calc.CalculateGrossSales(_horseQ2.Sold, _horseQ2.Price);
			double grossSalesQ2 = cowboyGrossSalesQ2 + horseGrossSalesQ2;
			double cowboyNetSalesQ2 = calc.CalculateNetSales(cowboyGrossSalesQ2, _cowboyQ2.Returned, _cowboyQ2.Price, _cowboyQ2.Discounts);
			double horseNetSalesQ2 = calc.CalculateNetSales(horseGrossSalesQ2, _horseQ2.Returned, _horseQ2.Price, _horseQ2.Discounts);
			double royaltiesOnCowboyQ2 = calc.CalculateRoyalties(cowboyNetSalesQ2, _cowboyQ2.Royalty);
			double royaltiesOnHorseQ2 = calc.CalculateRoyalties(horseNetSalesQ2, _horseQ2.Royalty);
			double cowboyReturnRateQ1 = calc.CalculateReturnRate(_cowboyQ1.Returned, _cowboyQ1.Sold);
			double cowboyReturnRateQ2 = calc.CalculateReturnRate(_cowboyQ2.Returned, _cowboyQ2.Sold);
			double commissionRate = 0.05;
			double cowboyCommissionTotal = calc.CalculateCommission(royaltiesOnCowboyQ2, commissionRate);
			double horseCommissionTotal = calc.CalculateCommission(royaltiesOnHorseQ2, commissionRate);

			//write out values for calculations
			Console.WriteLine("-----Q2 Calculations-----");
			Console.WriteLine($"Combined net sales for Q2: {(cowboyNetSalesQ2 + horseNetSalesQ2).ToString("c")}");
			Console.WriteLine($"Cowboy return rate for Q1: {cowboyReturnRateQ1.ToString("P")}");
			Console.WriteLine($"Cowboy return rate for Q2: {cowboyReturnRateQ2.ToString("P")}");
			Console.WriteLine($"Commission due for Cowboy Jim: {cowboyCommissionTotal.ToString("c")}");
			Console.WriteLine($"Commission due for Charlie Horse: {horseCommissionTotal.ToString("c")}");
			Console.WriteLine();
			#endregion

			#region Q4 Projections
			//create new object for Q4 cowboy
			Toy _cowboyQ4 = new Toy
			{
				Price = 8.98,
				Sold = 143046,
				Royalty = 0.045,
				Discounts = 79697,
				Returned = 4130
			};

			double cowboyQ4Returns = calc.CalculateReturnRate(_cowboyQ4.Returned, _cowboyQ4.Sold);
			double cowboyQ4Gross = calc.CalculateGrossSales(_cowboyQ4.Sold, _cowboyQ4.Price);
			double cowboyQ4Net = calc.CalculateNetSales(cowboyQ4Gross, _cowboyQ4.Returned, _cowboyQ4.Price, _cowboyQ4.Discounts);
			double cowboyQ4Royalty = calc.CalculateRoyalties(cowboyQ4Net, _cowboyQ4.Royalty);
			double cowboyQ4Commission = calc.CalculateCommission(cowboyQ4Royalty, commissionRate);

			Console.WriteLine("-----Q4 Projections-----");
			Console.WriteLine($"Cowboy Q4 return rate: {cowboyQ4Returns.ToString("P")}");
			Console.WriteLine($"Cowboy Q4 royalty amount: {cowboyQ4Royalty.ToString("c")}");
			Console.WriteLine($"Cowboy Q4 commission: {cowboyQ4Commission.ToString("c")}");

			#endregion

			Console.ReadKey();
		}
	}
}
