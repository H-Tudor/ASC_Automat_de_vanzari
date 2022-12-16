using System.Linq;
using System.Collections.Generic;

namespace ASC_Automat_de_vanzari {
	public class VendingMachine: IVendingMachine {

		string[] acceptedStringCoins = { "5", "10", "25" };
		private int[] acceptedIntCoins = { 5, 10, 25 };

		private int coinSum = 0;
		private List<int> coins = new List<int>();

		public VendingMachine() { }

		public bool InsertCoin(string coin) {
			if(!acceptedStringCoins.Contains(coin)) return false;

			coins.Add(int.Parse(coin));
			coinSum += coins.Last();

			return true;
		}

		public bool InsertCoin(int coin) {
			if(!acceptedIntCoins.Contains(coin)) return false;

			coins.Add(coin);
			coinSum += coins.Last();

			return true;
		}

		public bool CheckCoinSum {
			get {
				if(coinSum < 20) return false;
				return true;
			}
		}

		public List<int> Dispense() {
			List<int> toR = new List<int>();
			if(!CheckCoinSum) return toR;


			if(coinSum == 20) {
				coinSum = 0;
				coins = toR;
				return toR;
			}

			if(coins.Remove(25)) {
				coinSum = 0;
				(toR, coins) = (coins, toR);
				return toR;
			}

			coinSum = 0;
			toR.Add(5);
			return toR;
		}

		public List<int> ReturnCoins() {
			List<int> toR = new List<int>();
			(toR, coins) = (coins, toR);
			coinSum = 0;
			return toR;
		}
	}
}
