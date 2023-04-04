using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._04_04_2023
{
	internal class Pokers
	{
		public void PokerHandRanking(string[] cards)
		{
			// 3h, 5h, Qs, 9h, Ad
			Dictionary<string, string> alphaToValue = new Dictionary<string, string>()
			{
				{"J" ,"11" },
				{ "Q" ,"12" },
				{ "K" ,"13" },
				{ "A", "14" },
			};

			List<string> ranks = new List<string>();
			string[] suits = new string[cards.Length] ;
			int idx = 0 ;


			foreach (var card in cards)
			{

				string tmp = string.Join("", card.Substring(0, card.Length - 1));
				if(tmp.Length == 1)
				{
					if (!char.IsDigit(tmp[0]))
					{
						tmp = alphaToValue[tmp] ;
					}
				}
				ranks.Add(tmp);
				suits[idx] = string.Join("",card[card.Length - 1]);
				idx = idx + 1 ;

			}
			

			// Sorting the ranks
			ranks.Sort();
			List<string> royalFlushCombination = new List<string>{ "10", "11", "12", "13", "14" };

			int setSuits = suits.ToHashSet().Count;
			int sequenceChecker = (int.Parse(ranks.Max()) - int.Parse(ranks.Min()));// Need to improve
			int setRanks = ranks.ToHashSet().Count;
			// Check for Royal Flush
			if (setSuits == 1 && ranks.SequenceEqual(royalFlushCombination))
			{
				Console.WriteLine("Royal flush");
			}

			else if (setSuits == 1 && sequenceChecker == 4)
			{
				Console.WriteLine("Straight Flush");
			}

			else if (setSuits == 2) 
			{
				Console.WriteLine("Four of kind");
			}

			else if (setSuits == 3 && setRanks <= 4)
			{
				Console.WriteLine("Full House");
			}

			else if(setSuits == 1 && sequenceChecker != 4)
				Console.WriteLine("Flush");

			else if(setSuits == 5 && sequenceChecker == 4)
				Console.WriteLine("Straight");

			else if (setRanks == 3 && ThreeOfKindChecker(ranks))
			{
				Console.WriteLine("Three of kind");

			}

			else if (ranks.ToHashSet().Count == 3)
				Console.WriteLine("Two Pair");

			else if(setRanks == 4)
				Console.WriteLine("Pair");

			else
				Console.WriteLine("High Card");

		}

		public bool ThreeOfKindChecker(List<string> ranks)
		{

			Dictionary<string,int> tmpDict = new Dictionary<string,int>();
			
			foreach (string rank in ranks)
			{
				if (tmpDict.ContainsKey(rank))
					tmpDict[rank] += 1;
				else
					tmpDict[rank] = 1;
			}

            foreach (var key in tmpDict)
            {
				if (key.Value == 3)
					return true;
            }

            return false;
		}



	}
}

//string[] hand = { "10h", "Jh", "Qh", "Ah", "Kh" };// [9, 10, 11, 12, 13] => 9+2 = 11 = 13-2