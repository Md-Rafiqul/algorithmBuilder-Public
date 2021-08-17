using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoR
{
    public static class AlgoR
    {
		/// <summary>
		/// Given non empty array of distint integers, this function will return an array of two integers from the given array
		/// if any two distint integers sum up to the target integer
		/// </summary>
		/// <param name="array"></param>
		/// <param name="targetSum"></param>
		/// <returns>array of two integers: int[]</returns>
		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			for (int i = 0; i < array.Length - 1; i++)
			{
				int firstNum = array[i];
				for (int j = i + 1; j < array.Length; j++)
				{
					int secondNum = array[j];
					if (firstNum + secondNum == targetSum)
					{
						return new int[] { firstNum, secondNum };
					}
				}
			}
			return new int[0];
		}

		/// <summary>
		/// <para>Finds if the second array is a subsequence of the first array, Given two non empty array of integers</para> 
		/// <para>A subsequence of array is a set of numbers that aren't necessarily adjacent to the array, but that are in the same order as they appear in the array.</para>
		/// </summary>
		/// <param name="array"></param>
		/// <param name="sequence"></param>
		/// <returns></returns>
		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			int arrayIndex = 0;
			int seqIndex = 0;
			while (arrayIndex < array.Count && seqIndex < sequence.Count)
			{
				if (array[arrayIndex] == sequence[seqIndex])
				{
					seqIndex++;
				}
				arrayIndex++;
			}
			return seqIndex == sequence.Count;
		}

		/// <summary>
		/// Takes a non empty array of sorted integers
		/// <para>returns squared value of the same integers in sorted way.</para>
		/// </summary>
		/// <param name="array"></param>
		/// <returns>array of sorted integers: int[]</returns>
		public static int[] SortedSquaredArray(int[] array)
		{
			int[] newArray = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int val = array[i];
				newArray[i] = val * val;
			}
			Array.Sort(newArray);
			return newArray;
		}

		
		public static int NonConstructibleChange(int[] coins)
		{
			Array.Sort(coins);
			int currentChangedCoin = 0;
			foreach (int coin in coins)
			{
				if (coin > currentChangedCoin + 1)
				{
					return currentChangedCoin + 1;
				}
				currentChangedCoin += coin;
			}
			return currentChangedCoin + 1;
		}

		public static string TournamentWinner(List<List<string>> competitions, List<int> results)
		{
			Dictionary<string, int> scoreCard = new Dictionary<string, int>();
			string winnerTeam = "";
			scoreCard[winnerTeam] = 0;
			const int HOME_TEAM_WON = 1;

			for(int idx = 0; idx < competitions.Count; idx++)
            {
				List<string> currentCompetitors = new List<string>();
				
				currentCompetitors = competitions[idx];
				int currentResult = results[idx];
				string homeTeam = currentCompetitors[0];
				string awayTeam = currentCompetitors[1];
				string currentBest = (currentResult == HOME_TEAM_WON)
										? homeTeam
										: awayTeam;
				updateScore(currentBest, 3, scoreCard);
				winnerTeam = scoreCard[currentBest] > scoreCard[winnerTeam]
										? currentBest
										: winnerTeam;
				}
			return winnerTeam;

			void updateScore(string team, int points, Dictionary<string,int> _scoreCard)
            {
                if (!scoreCard.ContainsKey(team))
                {
					_scoreCard[team] = 0;
                }
                else
                {
					_scoreCard[team] = _scoreCard[team] + points;
                }
            }

			

		}

		
		
		public static int FindClosestValueInBst(BST tree, int target) {
		BST currentNode = tree;
		int closestValue = tree.value;
		while(currentNode != null){
			
			if(Math.Abs(target - closestValue) > Math.Abs(target - currentNode.value)){
				closestValue = currentNode.value;
			}
			if(target < currentNode.value){
			 	currentNode = currentNode.left;
			}
			else if(target > currentNode.value){
				currentNode = currentNode.right;
			}
			else
				break;
			
		}
		return closestValue;
	}


	public class Node {
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name) {
			this.name = name;
		}

		public List<string> DepthFirstSearch(List<string> array) {
			// Write your code here.
			return array;
		}

		public Node AddChild(string name) {
			Node child = new Node(name);
			children.Add(child);
			return this;
		}
	}

	
	}
}

