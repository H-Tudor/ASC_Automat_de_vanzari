using System;
using System.Collections.Generic;

namespace ASC_Automat_de_vanzari {
	internal class Program {
		static void Main(string[] args) {

			VendingMachine vm = new VendingMachine();
			while(true) {
				Console.WriteLine("Hello Customer");
				while(!vm.CheckCoinSum) {
					Console.Write("Insert Coin: ");
					string coin = Console.ReadLine();

					if(!vm.InsertCoin(coin)) Console.WriteLine("Unrecognised Coin");
				}

				List<int> coins = vm.Dispense();

				Console.Write("Product Dispensed, Coins Returned:");
				if(coins.Count != 0) {
					foreach(int coin in coins) { 
						Console.Write($" {coin}");
					}
					Console.WriteLine();
				} else {
					Console.WriteLine("none");
				}
			Console.ReadKey();
			}
		}
	}
}
