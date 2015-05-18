using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4CC
{
	class StockItem // main class from which others are derived
	{
		internal float CostPrice;
		internal string Description;
		public static int LastStockNumber = 10000; // starting stock number
		internal int StockNumber;

		public StockItem( int StockNumber, string Description, float CostPrice ) // for already assigned invoice #s
		{
			this.StockNumber = StockNumber;
			this.CostPrice = CostPrice;
			this.Description = Description;
		}

		public StockItem( string Description, float CostPrice ) // override StockItem for no invoice # assigned
		{
			this.StockNumber = LastStockNumber++;
			this.CostPrice = CostPrice;
			this.Description = Description;
		}

		public float GetCostPrice()
		{
			return CostPrice;
		}

		public virtual string Print() // prints information to text box
		{
			string Output = "";
			Output += "\r\n\r\n";
			Output += "Stock Item: ";
			Output += "\r\n";
			Output += "Stock No: " + StockNumber;
			Output += "\r\n";
			Output += "Desc: " + Description;
			Output += "\r\n";
			Output += "Cost: " + CostPrice;
			Output += "\r\n";
			return Output;
		}
	}

}
