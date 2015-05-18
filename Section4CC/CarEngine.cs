using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4CC
{
	class CarEngine : HeavyStockItem // derived from HeavyStockItem class 
	{
		internal string EngineNumber;

		public CarEngine( int StockNumber, string Description, float CostPrice, float Weight, string EngineNumber )
			: base( StockNumber, Description, CostPrice, Weight )
		{
			this.EngineNumber = EngineNumber;
		}

		public CarEngine( string Description, float CostPrice, float Weight, string EngineNumber ) // overload
			: base( Description, CostPrice, Weight )
		{
			LastStockNumber++;
			this.StockNumber = LastStockNumber;
		}

		public override String Print() // additional information printed of Engine Number
		{
			string Output = "";
			Output += base.Print();
			Output += "Engine Number: " + EngineNumber + "\r\n";
			return Output;
		}
	}
}
