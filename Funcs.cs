using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
	public class Funcs
	{
		public int countCondNums(int[] nums)
		{
			int count = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (checkAverageLTSeven(nums[i]) && checkMaxSeven(nums[i])) count++;
			}
			return count;
		}

		public bool checkAverageLTSeven(int num)
		{
			if ((num % 10 + (num / 10) % 10 + (num / 100) % 10 + num / 1000) / 4.0 < 7.0) return true;
			return false;
		}

		public bool checkMaxSeven(int num)
		{
			int max = 0;
			while (num > 0)
			{
				if (num % 10 > max) max = num % 10;
				num /= 10;
			}
			if (max == 7) return true;
			return false;
		}

		public int[] getNumsArray(string arrayString)
		{
			List<string> splitedArray = arrayString.Split(' ').ToList();
			splitedArray = splitedArray.Where(str => str != "").ToList();

			if (splitedArray.Count != 10) return null;
			int[] array = new int[10];

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Int32.Parse(splitedArray[i]);
				if (array[i] < 1000 || array[i] > 9999) return null;
			}
			return array;
		}

	}
}
