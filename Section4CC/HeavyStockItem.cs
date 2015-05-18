using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section4CC
{
	class HeavyStockItem : StockItem
	{
		internal float Weight;

		public HeavyStockItem( int StockNumber, string Description, float CostPrice, float Weight ) // constructor for HeavyStockItem information retrieval
			: base( StockNumber, Description, CostPrice )
		{
			this.Weight = Weight;
		}

		public HeavyStockItem( string Description, float CostPrice, float Weight ) // overload of above constructor
			: base( Description, CostPrice )
		{
			this.Weight = Weight;
		}

		public float GetWeight() // gets the weight and returns in order to add to output
		{
			return Weight;
		}

		public override String Print()
		{
			string Output = "";
			Output += base.Print();
			Output += "Weight: " + Weight + "\r\n";
			return Output;
		}
	}
}
