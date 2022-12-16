using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automat_de_vanzari {
	
	public interface IVendingMachine {
		
		bool InsertCoin(string coin);
		
		bool InsertCoin(int coin);

		List<int> Dispense();

		List<int> ReturnCoins();
	}
}
