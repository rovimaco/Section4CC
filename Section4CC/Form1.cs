using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section4CC
{
	public partial class form1 : Form

	{
		// stock items listed as per table
		StockItem StockItem1;
		CarEngine StockItem2;
		CarEngine StockItem3;
		StockItem StockItem4;
		HeavyStockItem StockItem5;


		private void ShowItem( StockItem PrintStockItem )
		{
			txtOutput.Text += PrintStockItem.Print(); // ShowItem created to write to text box
		}

		public form1()
		{
			InitializeComponent();
		}

		private void M_Load( object sender, EventArgs e ) // main information using methods from other classes
		{
			StockItem1 = new StockItem( "Screwdriver set", 42 );
			StockItem2 = new CarEngine( 8025, "MazdaB6T", 1252, 800, "Z4537298D" );
			StockItem3 = new CarEngine( "Holden 308", 958, 1104, "P74623854S" );
			StockItem4 = new StockItem( 8002, "Trolley Jack", 127 );
			StockItem5 = new HeavyStockItem( "JD Caterpillar Track", 3820, 2830 );
		}

		private void btnList_Click( object sender, EventArgs e ) // when button pushed the items are displayed
		{
			ShowItem( StockItem1 );
			ShowItem( StockItem2 );
			ShowItem( StockItem3 );
			ShowItem( StockItem4 );
			ShowItem( StockItem5 );
		}
	}
}
